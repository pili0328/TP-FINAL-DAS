using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVentas
    {
        private Context context;
        
        public RepositorioVentas(Context context)
        
        {
            context = new Context();
        }

        public IReadOnlyCollection<Venta> ListarVentas()
        {
            return context.Ventas.ToList().AsReadOnly();
        }

        public void Agregar(Venta venta)
        {
            foreach (var detalle in venta.Detalles)
            {
                var stock = context.StockSucursal
                    .FirstOrDefault(s => s.ProductoId == detalle.ProductoId && s.SucursalId == venta.SucursalId);

                if (stock == null || stock.Cantidad < detalle.Cantidad)
                {
                    throw new Exception($"Stock insuficiente para el producto {detalle.ProductoId}");
                }

                stock.Cantidad -= detalle.Cantidad;
            }

            
            if (venta.MetodoPago == "CuentaCorriente")
            {
                var cliente = context.Cliente.Find(venta.ClienteId);
                if (cliente != null)
                {
                    cliente.CuentaCorriente += venta.Total;
                }
            }

       
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        public List<Venta> ObtenerVentaPorPeriodo(DateTime start, DateTime end) // GetVentasByPeriod
        {
            return context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Vendedor)
                .Include(v => v.Sucursal)
                .Where(v => v.Fecha >= start && v.Fecha <= end)
                .ToList();
        }

        public List<Venta> ObtenerVenta()
        {
            return context.Ventas.ToList();
        }

       

    }
    
}
