using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public bool Activo { get; set; } = true;

        public int SucursalId { get; set; }

        public Sucursal Sucursal { get; set; } //  lo cree para poder llamarlo desde el cb de productos. 

        public virtual List<StockSucursal> StockSucursales { get; set; } = new List<StockSucursal>();
    }
}
