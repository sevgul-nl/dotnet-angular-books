using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");
        }
    }
}
