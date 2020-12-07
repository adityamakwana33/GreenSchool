using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenSchool.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professsors",
                columns: table => new
                {
                    ProfessorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessorLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessorType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professsors", x => x.ProfessorID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Professsors_ProfessorFK",
                        column: x => x.ProfessorFK,
                        principalTable: "Professsors",
                        principalColumn: "ProfessorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfessorFK",
                table: "Students",
                column: "ProfessorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Professsors");
        }
    }
}
