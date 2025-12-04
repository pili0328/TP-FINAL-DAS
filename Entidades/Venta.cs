namespace Entidades
{
    public class Venta
    {

        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        
        public Vendedor Vendedor { get; set; }

        public int SucursalId { get; set; }
        
        public Sucursal Sucursal { get; set; }

        public string MetodoPago { get; set; } // Efectivo, Tarjeta, Transferencia, CuentaCorriente

        public decimal Total { get; set; }

        public virtual List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

    }
}
