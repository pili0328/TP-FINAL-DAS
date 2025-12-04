using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProducto
    {
        private readonly Context contexto;
       
        public RepositorioProducto(Context context)
        {
            contexto = context;
        }

        public List<Producto> ListarTodos()
        {
            return contexto.Productos.Include(p => p.Categoria).ToList();
        }
        public Producto ObtenerId(int id)
        {
            return contexto.Productos.Find(id);
        }
       
        public void Agregar(Producto producto)
        {
            contexto.Productos.Add(producto);
            contexto.SaveChanges();
        }
       

        public void Modificar(Producto producto)
        {
            contexto.Productos.Update(producto);
            contexto.SaveChanges();
        }

        public void Eliminar(int ProductoId)
        {
            var productoAEliminar = contexto.Productos.Find(ProductoId);
            if (productoAEliminar != null)
            {
                contexto.Productos.Remove(productoAEliminar);
                contexto.SaveChanges();
            }
        }

        public List<StockSucursal> GetStock(int productoId)
        {
            return contexto.StockSucursal
                .Include(s => s.Sucursal)
                .Where(s => s.ProductoId == productoId)
                .ToList();
        }

    }
}


