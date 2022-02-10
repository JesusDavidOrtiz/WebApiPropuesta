using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPropuesta.Migrations
{
    public partial class MigracionWEB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_fabricación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_validez = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cod_proveedor = table.Column<int>(type: "int", nullable: false),
                    Descripción_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoProveedor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
