using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CompanyApplication.Migrations
{
    public partial class DepartmentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmnetId",
                table: "employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DepartmentNumber = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DepartmentNumber);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmnetId",
                table: "employees",
                column: "DepartmnetId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmnetId",
                table: "employees",
                column: "DepartmnetId",
                principalTable: "departments",
                principalColumn: "DepartmentNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmnetId",
                table: "employees");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmnetId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DepartmnetId",
                table: "employees");
        }
    }
}
