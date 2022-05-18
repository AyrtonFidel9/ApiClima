using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiClima.Migrations
{
    public partial class AddClimaTemperatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Temperatura",
                table: "Climas",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperatura",
                table: "Climas");
        }
    }
}
