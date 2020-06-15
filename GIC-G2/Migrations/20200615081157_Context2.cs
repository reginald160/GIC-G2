using Microsoft.EntityFrameworkCore.Migrations;

namespace GIC_G2.Migrations
{
    public partial class Context2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "EmployeeTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeTable",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "EmployeeTable",
                type: "nvarchar(11)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeTable",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
