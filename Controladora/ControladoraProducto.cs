using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelo;
using System.Security.Authentication;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraProducto //este ya esta
    {
        private RepositorioProducto reposProducto;
        private Context context;
        private RepositorioVentas reposVenta;

        private static ControladoraProducto instancia;

        public static ControladoraProducto Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraProducto();
                return instancia;
            }
        }

        public ControladoraProducto()
        {
            context = new Context();
            reposProducto = new RepositorioProducto(context);
            reposVenta = new RepositorioVentas(context);
        }

        public List<Producto> ListarProductos()
        {
            return reposProducto.ListarTodos();
        }

        public void CrearProducto(Producto producto)
        {
            reposProducto.Agregar(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            reposProducto.Modificar(producto);
        }
        public void EliminarProducto(int eliminar)
        {
            reposProducto.Eliminar(eliminar);
        }

        public Producto ObtenerPorId(int id)
        {
            return reposProducto.ObtenerId(id);
        }

        // método para agregar o actualizar stock en una sucursal específica
        public void AgregarStockASucursal(int productoId, int sucursalId, int cantidad)
        {
            var stockExistente = context.StockSucursales
                .FirstOrDefault(s => s.ProductoId == productoId && s.SucursalId == sucursalId); 

            if (stockExistente != null)
            {
                stockExistente.Cantidad += cantidad;
                context.StockSucursales.Update(stockExistente);
            }
            else
            {

                StockSucursal nuevoStock = new StockSucursal
                {
                    ProductoId = productoId,
                    SucursalId = sucursalId, //se asigna a la sucursal nueva
                    Cantidad = cantidad
                };
                context.StockSucursales.Add(nuevoStock);
            }

            context.SaveChanges();
        }

        //este metodo es para no pasarse de los limites al asignar el stock en gestion de stock
        public void AsignarStockControlado(int idProducto, int idSucursal, int cantidadAAsignar)
        {
            var productoPadre = context.Productos.Find(idProducto);

            int stockTotalGlobal = productoPadre.Cantidad; 

            int stockYaRepartido = context.StockSucursales.Where(s => s.ProductoId == idProducto).Sum(s => s.Cantidad);

            int stockDisponible = stockTotalGlobal - stockYaRepartido;

            if (cantidadAAsignar > stockDisponible)
            {
                throw new Exception($"No puedes asignar {cantidadAAsignar}. Solo quedan {stockDisponible} unidades sin asignar del total de {stockTotalGlobal}.");
            }

            AgregarStockASucursal(idProducto, idSucursal, cantidadAAsignar);
        }

        public List<ProductoVista> ListarPorSucursal(int sucursalId) //el view model sirve para el data grid view
        {
            var lista = context.StockSucursales
                .Where(s => s.SucursalId == sucursalId)
                .Select(s => new ProductoVista  
                {
                    IdProducto = s.ProductoId,
                    Producto = s.Producto.Nombre,
                    Precio = s.Producto.Precio,
                    Stock = s.Cantidad,
                    Sucursal = s.Sucursal.Nombre
                })
                .ToList();

            return lista;
        }

        public List<ReporteProducto> ObtenerRankingGeneral() //esto es para lo de reportes
        {
            var todasLasVentas = reposVenta.ObtenerVenta();

            var listaRanking = todasLasVentas
                .SelectMany(v => v.Detalles)
                .GroupBy(d => d.Producto.Nombre)
                .Select(grupo => new ReporteProducto 
                {
                    Nombre = grupo.Key,
                    Cantidad = grupo.Sum(x => x.Cantidad)
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            return listaRanking;
        }


        public class ProductoVista
        {
            public int IdProducto { get; set; } 
            public string Producto { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
            public string Sucursal { get; set; }
        }

    }
}
