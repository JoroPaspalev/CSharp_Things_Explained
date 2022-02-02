using Microsoft.EntityFrameworkCore.Migrations;

namespace N_plus_One_Problem_In_EFCore.Migrations
{
    public partial class AddTownToCats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "Cats",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Town",
                table: "Cats");
        }
    }
}
