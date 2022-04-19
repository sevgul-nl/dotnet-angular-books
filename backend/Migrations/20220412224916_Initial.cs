using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Rating", "Title" },
                values: new object[] { 1L, "Herman Melville", 3, "Moby Dick" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Rating", "Title" },
                values: new object[] { 2L, "Charles Dickens", 3, "A Tale of Two Cities" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Rating", "Title" },
                values: new object[] { 3L, "Leo Tolstoy", 3, "War and Peace" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Rating", "Title" },
                values: new object[] { 4L, "Charlotte Brontë", 3, "Jane Eyre" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Rating", "Title" },
                values: new object[] { 5L, "James Joyce", 3, "Ulysses" });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BookId",
                table: "Ratings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_BookId",
                table: "Subjects",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
