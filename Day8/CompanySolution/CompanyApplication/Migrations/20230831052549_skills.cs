using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyApplication.Migrations
{
    public partial class skills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    SkillName = table.Column<string>(type: "text", nullable: false),
                    SkillDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.SkillName);
                });

            migrationBuilder.CreateTable(
                name: "employeesskills",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    SkillName = table.Column<string>(type: "text", nullable: false),
                    SkillLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeesskills", x => new { x.EmployeeId, x.SkillName });
                    table.ForeignKey(
                        name: "FK_employeesskills_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employeesskills_skills_SkillName",
                        column: x => x.SkillName,
                        principalTable: "skills",
                        principalColumn: "SkillName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "DepartmentNumber", "Name" },
                values: new object[,]
                {
                    { 1, "Operations" },
                    { 2, "HR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeesskills_SkillName",
                table: "employeesskills",
                column: "SkillName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeesskills");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "DepartmentNumber",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "DepartmentNumber",
                keyValue: 2);
        }
    }
}
