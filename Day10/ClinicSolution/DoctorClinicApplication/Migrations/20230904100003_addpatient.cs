using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorClinicApplication.Migrations
{
    public partial class addpatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "Id", "Age", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 22, "kim@gmail.com", "Kim", "5454545454" },
                    { 2, 56, "lom@gmail.com", "Lom", "9898989898" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
