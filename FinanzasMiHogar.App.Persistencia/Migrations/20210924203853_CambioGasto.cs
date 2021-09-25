using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasMiHogar.App.Persistencia.Migrations
{
    public partial class CambioGasto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_Gasto_gastoId",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto");

            migrationBuilder.RenameTable(
                name: "Gasto",
                newName: "gasto");

            migrationBuilder.RenameColumn(
                name: "tiposGastos",
                table: "gasto",
                newName: "TipoGasto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gasto",
                table: "gasto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_gasto_gastoId",
                table: "usuario",
                column: "gastoId",
                principalTable: "gasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_gasto_gastoId",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gasto",
                table: "gasto");

            migrationBuilder.RenameTable(
                name: "gasto",
                newName: "Gasto");

            migrationBuilder.RenameColumn(
                name: "TipoGasto",
                table: "Gasto",
                newName: "tiposGastos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_Gasto_gastoId",
                table: "usuario",
                column: "gastoId",
                principalTable: "Gasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
