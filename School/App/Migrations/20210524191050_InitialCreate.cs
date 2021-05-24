using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Classification = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<float>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 1, 22, 0, "Barry", "Allen" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 2, 42, 1, "Frank", "Castle" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 3, 29, 2, "Clark", "Kent" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 4, 39, 3, "Bruce", "Wayne" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 5, 19, 0, "Gwen", "Stacy" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Classification", "FirstName", "LastName" },
                values: new object[] { 6, 19, 0, "Peter", "Parker" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 1, "Track 302", 1, 99.5f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 4, "Martial Arts 302", 1, 100f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 2, "Track 302", 2, 45f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 5, "Martial Arts 302", 2, 98.99f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 3, "Track 302", 3, 87.25f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 6, "Calculus 302", 4, 76.5f });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "StudentId", "Value" },
                values: new object[] { 7, "Calculus 302", 5, 88f });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
