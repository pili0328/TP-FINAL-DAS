using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Productos_ProductoID",
                table: "StockSucursal");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Sucursal_SucursalID",
                table: "StockSucursal");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "VentaId",
                table: "Ventas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendedor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "Sucursal",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SucursalID",
                table: "StockSucursal",
                newName: "SucursalId");

            migrationBuilder.RenameColumn(
                name: "ProductoID",
                table: "StockSucursal",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "CantidadStock",
                table: "StockSucursal",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "StockSucursalId",
                table: "StockSucursal",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_SucursalID",
                table: "StockSucursal",
                newName: "IX_StockSucursal_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_ProductoID",
                table: "StockSucursal",
                newName: "IX_StockSucursal_ProductoId");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Productos",
                newName: "CategoriaId");

            migrationBuilder.RenameColumn(
                name: "Disponible",
                table: "Productos",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                table: "Ventas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "CuentaCorriente",
                table: "Cliente",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Dni",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_SucursalId",
                table: "Ventas",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_ProductoId",
                table: "DetalleVenta",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_VentaId",
                table: "DetalleVenta",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursal_Productos_ProductoId",
                table: "StockSucursal",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursal_Sucursal_SucursalId",
                table: "StockSucursal",
                column: "SucursalId",
                principalTable: "Sucursal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Sucursal_SucursalId",
                table: "Ventas",
                column: "SucursalId",
                principalTable: "Sucursal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Productos_ProductoId",
                table: "StockSucursal");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Sucursal_SucursalId",
                table: "StockSucursal");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursal_SucursalId",
                table: "Ventas");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_SucursalId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "MetodoPago",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "CuentaCorriente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ventas",
                newName: "VentaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendedor",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sucursal",
                newName: "SucursalId");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "StockSucursal",
                newName: "SucursalID");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "StockSucursal",
                newName: "ProductoID");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "StockSucursal",
                newName: "CantidadStock");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StockSucursal",
                newName: "StockSucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_SucursalId",
                table: "StockSucursal",
                newName: "IX_StockSucursal_SucursalID");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_ProductoId",
                table: "StockSucursal",
                newName: "IX_StockSucursal_ProductoID");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Productos",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Productos",
                newName: "Disponible");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "ClienteId");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroFactura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_VentaId",
                table: "Factura",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursal_Productos_ProductoID",
                table: "StockSucursal",
                column: "ProductoID",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursal_Sucursal_SucursalID",
                table: "StockSucursal",
                column: "SucursalID",
                principalTable: "Sucursal",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
