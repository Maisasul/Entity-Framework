using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC3.Migrations
{
    /// <inheritdoc />
    public partial class editedrelationbetweenblogandpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_Post_postid",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_postid",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "postid",
                table: "blogs");

            migrationBuilder.AddColumn<int>(
                name: "blogsid",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Post_blogsid",
                table: "Post",
                column: "blogsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_blogs_blogsid",
                table: "Post",
                column: "blogsid",
                principalTable: "blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_blogs_blogsid",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_blogsid",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "blogsid",
                table: "Post");

            migrationBuilder.AddColumn<int>(
                name: "postid",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_postid",
                table: "blogs",
                column: "postid");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_Post_postid",
                table: "blogs",
                column: "postid",
                principalTable: "Post",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
