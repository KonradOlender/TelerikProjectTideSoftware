using Microsoft.EntityFrameworkCore.Migrations;

namespace TelerikProject.Migrations
{
    public partial class imagechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageString",
                table: "estates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageString",
                table: "estates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
