using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasMiHogar.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreGastos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    montoDinero = table.Column<int>(type: "int", nullable: false),
                    fechaPago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiposGastos = table.Column<int>(type: "int", nullable: false),
                    periodoGastos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gastoId = table.Column<int>(type: "int", nullable: true),
                    topeGastos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_Gasto_gastoId",
                        column: x => x.gastoId,
                        principalTable: "Gasto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuario_gastoId",
                table: "usuario",
                column: "gastoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "Gasto");
        }
    }
}
