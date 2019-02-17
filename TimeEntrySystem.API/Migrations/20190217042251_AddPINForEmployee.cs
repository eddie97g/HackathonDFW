using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeEntrySystem.API.Migrations
{
    public partial class AddPINForEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PIN",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PIN",
                table: "Employees");
        }
    }
}
