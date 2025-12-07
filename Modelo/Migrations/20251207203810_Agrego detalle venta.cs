using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Agregodetalleventa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoId",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Ventas_VentaId",
                table: "DetalleVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta");

            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "Detalle");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_VentaId",
                table: "Detalle",
                newName: "IX_Detalle_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_ProductoId",
                table: "Detalle",
                newName: "IX_Detalle_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detalle",
                table: "Detalle",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_Productos_ProductoId",
                table: "Detalle",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_Ventas_VentaId",
                table: "Detalle",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_Productos_ProductoId",
                table: "Detalle");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_Ventas_VentaId",
                table: "Detalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detalle",
                table: "Detalle");

            migrationBuilder.RenameTable(
                name: "Detalle",
                newName: "DetalleVenta");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_VentaId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_ProductoId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoId",
                table: "DetalleVenta",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Ventas_VentaId",
                table: "DetalleVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
