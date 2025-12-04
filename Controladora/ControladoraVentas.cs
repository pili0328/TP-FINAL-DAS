using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraVentas
    {
        private readonly RepositorioVentas repositorio;
        private readonly Context contexto;
        private readonly ControladoraCliente controlCliente;

        private static ControladoraVentas instancia;

        public static ControladoraVentas Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraVentas();
                return instancia;
            }
        }

        public ControladoraVentas()
        {
            contexto = new Context();
            repositorio = new RepositorioVentas(contexto);
            controlCliente = new ControladoraCliente();
        }

        public void ProcesarVenta(Venta venta)
        {
            // 1. Recalcular el total sumando los detalles (Seguridad)
            // Asumimos que los detalles ya tienen PrecioUnitario y Cantidad
            decimal subtotal = 0;
            foreach (var d in venta.Detalles)
            {
                subtotal += d.Subtotal;
            }
            venta.Total = subtotal;

            // 2. Cargar Cliente si hace falta, porque faltaria???
            if (venta.Cliente == null && venta.ClienteId > 0)
            {
                var clienteRepo = new RepositorioCliente(contexto); 
                venta.Cliente = clienteRepo.ObtenerPorId(venta.ClienteId);
            }


            if (venta.Cliente != null) // calcula el descuento!!!
            {
                // La Venta le PREGUNTA al controlador de Cliente cuánto debe descontar
                decimal descuento = controlCliente.CalcularDescuento(venta.Cliente, venta.Total); 

                venta.Total -= descuento;
            }

            // 4. Limpiar referencias circulares para Entity Framework, dafuq
            foreach (var detalle in venta.Detalles)
            {
                detalle.Producto = null;
            }

            repositorio.Agregar(venta);
        }

        public List<Venta> ReporteVentas(DateTime inicio, DateTime fin)
        {
            return repositorio.ObtenerVentaPorPeriodo(inicio, fin); // desde el form pasa lo que le ponemos en el form del dt picker
        }
    }
}
