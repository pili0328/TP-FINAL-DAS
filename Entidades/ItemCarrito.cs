using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemCarrito
    {
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public string Sucursal { get; set; }
        public string MetodoPago { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public ItemCarrito() { }
        public ItemCarrito(int idCli, string nomCli, dynamic prodObj, string vend, string suc, int cant, string pago)
        {
            this.ClienteId = idCli;
            this.ProductoId = (int)prodObj.IdProducto;
            this.Cliente = nomCli;
            this.Producto = prodObj.Producto;
            this.Precio = (decimal)prodObj.Precio;
            this.Vendedor = vend;
            this.Sucursal = suc;
            this.Cantidad = cant;
            this.MetodoPago = pago;
        }

        public decimal TotalMostrado
        {
            get
            {
                if (MetodoPago == "Cuenta Corriente")
                    return Precio * Cantidad; // el total sigue igual, solo se muestra
                else
                    return Precio * Cantidad;
            }
        }

    }
}
