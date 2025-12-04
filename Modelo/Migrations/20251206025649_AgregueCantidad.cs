using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AgregueCantidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Productos_ProductoId",
                table: "StockSucursal");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursal_Sucursal_SucursalId",
                table: "StockSucursal");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursal_SucursalId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockSucursal",
                table: "StockSucursal");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Sucursal",
                newName: "Sucursales");

            migrationBuilder.RenameTable(
                name: "StockSucursal",
                newName: "StockSucursales");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_SucursalId",
                table: "StockSucursales",
                newName: "IX_StockSucursales_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursal_ProductoId",
                table: "StockSucursales",
                newName: "IX_StockSucursales_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockSucursales",
                table: "StockSucursales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursales_Productos_ProductoId",
                table: "StockSucursales",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursales_Sucursales_SucursalId",
                table: "StockSucursales",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Sucursales_SucursalId",
                table: "Ventas",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursales_Productos_ProductoId",
                table: "StockSucursales");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursales_Sucursales_SucursalId",
                table: "StockSucursales");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursales_SucursalId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockSucursales",
                table: "StockSucursales");

            migrationBuilder.RenameTable(
                name: "Sucursales",
                newName: "Sucursal");

            migrationBuilder.RenameTable(
                name: "StockSucursales",
                newName: "StockSucursal");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursales_SucursalId",
                table: "StockSucursal",
                newName: "IX_StockSucursal_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_StockSucursales_ProductoId",
                table: "StockSucursal",
                newName: "IX_StockSucursal_ProductoId");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockSucursal",
                table: "StockSucursal",
                column: "Id");

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
    }
}
