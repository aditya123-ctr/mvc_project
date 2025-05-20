using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNovaSolutions.Migrations
{
    /// <inheritdoc />
    public partial class TechNova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeName = table.Column<string>(type: "varchar(100)", nullable: false),
                    EmployeAge = table.Column<int>(type: "int", nullable: false),
                    EmpOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
