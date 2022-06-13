using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDataBase.Data.Migrations
{
    public partial class DepartmentPosAndNumb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepartmentNumber",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentPosition",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentPosition",
                table: "Users");
        }
    }
}
