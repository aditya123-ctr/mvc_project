using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNovaSolutions.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeEmails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpEmail",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpEmail",
                table: "Employees");
        }
    }
}
