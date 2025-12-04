using Microsoft.EntityFrameworkCore;
using Entidades;


namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Sucursal> Sucursal { get; set; }

        public DbSet<StockSucursal> StockSucursal { get; set; }

        public DbSet<Vendedor> Vendedor { get; set; }
        private string conexion = "Data Source=AYACOPINO-NTB\\SQLEXPRESS;Initial Catalog=TechStoreSA;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);
    }
}
