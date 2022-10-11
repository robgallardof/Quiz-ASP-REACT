using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TimeTaken = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionInWords = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OptionOne = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OptionTwo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OptionThree = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OptionFour = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
