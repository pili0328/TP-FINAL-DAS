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

        public int Cantidad {  get; set; }
        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }


    }
}

