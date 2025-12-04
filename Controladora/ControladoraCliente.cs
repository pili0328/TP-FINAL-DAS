using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;
using static Entidades.Cliente;

namespace Controladora
{
    public class ControladoraCliente
    {
        private RepositorioCliente repos;
        private Context context;

        private static ControladoraCliente instancia;

        public static ControladoraCliente Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraCliente();
                return instancia;
            }
        }

        public ControladoraCliente()
        {
            context = new Context();
            repos = new RepositorioCliente(context);
        }

        public List<Cliente> ListarClientes()
        {
            return repos.ListarClientes();
        }

        public void AgregarCliente(Cliente cliente)
        {
            repos.AgregarCliente(cliente);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            repos.ModificarCliente(cliente);
        }

        public void EliminarCliente(int eliminar)
        {
            repos.Eliminar(eliminar);
        }
       

        public decimal CalcularDescuento(Cliente cliente, decimal totalCompra) // calcula el descuento y lo pasamos en la controladora de venta
        {
            // Comparamos contra el ENUM, no contra un string
            if (cliente.Tipo == TipoCliente.Mayorista)
            {
                return totalCompra * 0.10m; // 10% de descuento
            }

            // Si es Minorista (o cualquier otro), el descuento es 0
            return 0;
        }
    }
}
