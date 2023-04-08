using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Purple_Buzz.Migrations
{
    public partial class AddNewSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "HomeSliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "HomeSliders");
        }
    }
}
