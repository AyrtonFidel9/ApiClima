using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiClima.Migrations
{
    public partial class ApiMigrationsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Climas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    pais = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ciudad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    probPrecipitaciones = table.Column<double>(type: "float", nullable: true),
                    humedad = table.Column<double>(type: "float", nullable: true),
                    viento = table.Column<double>(type: "float", nullable: true),
                    sensacion = table.Column<int>(type: "int", nullable: true),
                    descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climas");
        }
    }
}
