using Microsoft.EntityFrameworkCore.Migrations;

namespace EFX.Data.Migrations
{
    public partial class AddedSports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "Sports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sports",
                table: "Customers",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "ContractNumber",
                table: "Customers",
                nullable: true);
        }
    }
}
