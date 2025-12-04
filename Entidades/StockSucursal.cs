using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockSucursal
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        
        public Producto Producto { get; set; }

        public int SucursalId { get; set; }
        
        public Sucursal Sucursal { get; set; }

        public int Cantidad { get; set; }

    }
}
