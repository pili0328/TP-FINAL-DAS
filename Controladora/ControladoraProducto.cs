using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelo;
using System.Security.Authentication;

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

        public List<StockSucursal> ConsultarDisponibilidad(int productoId)
        {
            return reposProducto.GetStock(productoId);
        }


        public Producto ObtenerPorId(int id)
        {
            return reposProducto.ObtenerId(id);
        }

        public List<ReporteProducto> ObtenerRankingGeneral()
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



    }
}
