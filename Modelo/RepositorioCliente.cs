using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class RepositorioCliente
    {
        private readonly Context contexto;

        public RepositorioCliente(Context context)
        {
            contexto = context;
        }

        public List<Cliente> ListarClientes()
        {
            return contexto.Cliente.ToList();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            contexto.Cliente.Add(unCliente);
            contexto.SaveChanges();
        }
        public void ModificarCliente(Cliente unCliente)
        {

            var clienteEnMemoria = contexto.Cliente.Local.FirstOrDefault(c => c.Id == unCliente.Id);

            if (clienteEnMemoria != null)
            {
                contexto.Entry(clienteEnMemoria).State = EntityState.Detached;
            }

            contexto.Entry(unCliente).State = EntityState.Modified;

            contexto.SaveChanges();
        }

        public void Eliminar(int clienteId)
        {
            var clienteAEliminar = contexto.Cliente.Find(clienteId);
            if (clienteAEliminar != null)
            {
                contexto.Cliente.Remove(clienteAEliminar);
                contexto.SaveChanges();
            }
        }

        public Cliente? ObtenerPorId(int id)
        {
            return contexto.Cliente.Find(id);
        }
    }
    
}

