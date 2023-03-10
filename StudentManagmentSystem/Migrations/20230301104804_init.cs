using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    StudentMobile = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AbcId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    MaritialStatus = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    IdType = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FatherMobile = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FatherEmail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MotherMobile = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MotherEmail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Cluster = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other1 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other3 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other4 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other5 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Other6 = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetail_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_StudentId",
                table: "EducationDetail",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetail");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
