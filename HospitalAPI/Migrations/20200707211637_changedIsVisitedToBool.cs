using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAPI.Migrations
{
    public partial class changedIsVisitedToBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsVisited",
                schema: "pmwebsit_HospitalDB",
                table: "Patient",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsVisited",
                schema: "pmwebsit_HospitalDB",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
