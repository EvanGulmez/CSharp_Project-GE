using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppli_GE.Migrations
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Heroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MyMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyMovie", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_MoviesId",
                table: "Heroes",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_MyMovie_MoviesId",
                table: "Heroes",
                column: "MoviesId",
                principalTable: "MyMovie",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_MyMovie_MoviesId",
                table: "Heroes");

            migrationBuilder.DropTable(
                name: "MyMovie");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_MoviesId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Heroes");
        }
    }
}
