using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoolFlix.Migrations
{
    public partial class New_column_to_VideoContents_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "VideoContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "VideoContents");
        }
    }
}
