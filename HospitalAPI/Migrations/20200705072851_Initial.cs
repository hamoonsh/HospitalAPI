using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pmwebsit_HospitalDB");

            migrationBuilder.CreateTable(
                name: "Doctor",
                schema: "pmwebsit_HospitalDB",
                columns: table => new
                {
                    DoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Family = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorID);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                schema: "pmwebsit_HospitalDB",
                columns: table => new
                {
                    HospitalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    levelZeroVisitingTime = table.Column<int>(nullable: false),
                    levelOneVisitingTime = table.Column<int>(nullable: false),
                    levelTwoVisitingTime = table.Column<int>(nullable: false),
                    levelThreeVisitingTime = table.Column<int>(nullable: false),
                    levelFourVisitingTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.HospitalID);
                });

            migrationBuilder.CreateTable(
                name: "HospitalDoctor",
                schema: "pmwebsit_HospitalDB",
                columns: table => new
                {
                    HospitalDoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalID = table.Column<int>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalDoctor", x => x.HospitalDoctorID);
                    table.ForeignKey(
                        name: "FK_HospitalDoctor_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalSchema: "pmwebsit_HospitalDB",
                        principalTable: "Doctor",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalDoctor_Hospital_HospitalID",
                        column: x => x.HospitalID,
                        principalSchema: "pmwebsit_HospitalDB",
                        principalTable: "Hospital",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "pmwebsit_HospitalDB",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegTime = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    IsVisited = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patient_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalSchema: "pmwebsit_HospitalDB",
                        principalTable: "Doctor",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Hospital_HospitalID",
                        column: x => x.HospitalID,
                        principalSchema: "pmwebsit_HospitalDB",
                        principalTable: "Hospital",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "pmwebsit_HospitalDB",
                table: "Doctor",
                columns: new[] { "DoctorID", "Family", "Name" },
                values: new object[,]
                {
                    { 1, "Javadi", "Javad" },
                    { 2, "Javidi", "Javid" },
                    { 3, "Mahdavi", "Mahdi" },
                    { 4, "kamrani", "Kamran" },
                    { 5, "Soheili", "Soheil" },
                    { 6, "Alavi", "Ali" }
                });

            migrationBuilder.InsertData(
                schema: "pmwebsit_HospitalDB",
                table: "Hospital",
                columns: new[] { "HospitalID", "Name", "levelFourVisitingTime", "levelOneVisitingTime", "levelThreeVisitingTime", "levelTwoVisitingTime", "levelZeroVisitingTime" },
                values: new object[,]
                {
                    { 1, "Hospital A", 38, 7, 30, 16, 5 },
                    { 2, " Hospital B", 29, 11, 20, 15, 10 },
                    { 3, "Hospital C", 30, 18, 20, 20, 15 },
                    { 4, "Hospital D", 28, 10, 20, 15, 10 },
                    { 5, "Hospital E", 32, 20, 25, 20, 18 },
                    { 6, "Hospital F", 38, 20, 32, 30, 12 }
                });

            migrationBuilder.InsertData(
                schema: "pmwebsit_HospitalDB",
                table: "HospitalDoctor",
                columns: new[] { "HospitalDoctorID", "DoctorID", "HospitalID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDoctor_DoctorID",
                schema: "pmwebsit_HospitalDB",
                table: "HospitalDoctor",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDoctor_HospitalID",
                schema: "pmwebsit_HospitalDB",
                table: "HospitalDoctor",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorID",
                schema: "pmwebsit_HospitalDB",
                table: "Patient",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_HospitalID",
                schema: "pmwebsit_HospitalDB",
                table: "Patient",
                column: "HospitalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalDoctor",
                schema: "pmwebsit_HospitalDB");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "pmwebsit_HospitalDB");

            migrationBuilder.DropTable(
                name: "Doctor",
                schema: "pmwebsit_HospitalDB");

            migrationBuilder.DropTable(
                name: "Hospital",
                schema: "pmwebsit_HospitalDB");
        }
    }
}
