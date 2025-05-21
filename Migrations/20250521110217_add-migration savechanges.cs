using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNovaSolutions.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationsavechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeAge",
                table: "Employees",
                newName: "EmpAge");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpAge",
                table: "Employees",
                newName: "EmployeAge");
        }
    }
}
