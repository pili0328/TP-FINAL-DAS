using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }
        
        public TipoCliente Tipo { get; set; }
        

        public decimal CuentaCorriente { get; set; } = 0;

        public virtual List<Venta> Compras { get; set; } = new List<Venta>();

        public enum TipoCliente
        {
            Minorista,
            Mayorista,
        }

    }

}
