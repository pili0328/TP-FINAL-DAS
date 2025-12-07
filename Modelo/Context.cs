using Microsoft.EntityFrameworkCore;
using Entidades;


namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }

        public DbSet<StockSucursal> StockSucursales { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet<DetalleVenta> Detalle {  get; set; }

        //private string conexion = "Data Source=AYACOPINO-NTB\\SQLEXPRESS;Initial Catalog=TechStoreSA;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;";
        private string conexion = "Data Source=DESKTOP-A276CKC\\SQLEXPRESS;Initial Catalog=TechStoreSA;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
        }

    }
}
