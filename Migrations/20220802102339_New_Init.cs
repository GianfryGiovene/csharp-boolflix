using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoolFlix.Migrations
{
    public partial class New_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaybackHistories");

            migrationBuilder.CreateTable(
                name: "PlaylistVideoContent",
                columns: table => new
                {
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    VideoContentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistVideoContent", x => new { x.PlaylistsId, x.VideoContentsId });
                    table.ForeignKey(
                        name: "FK_PlaylistVideoContent_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistVideoContent_VideoContents_VideoContentsId",
                        column: x => x.VideoContentsId,
                        principalTable: "VideoContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileVideoContent",
                columns: table => new
                {
                    ProfilesId = table.Column<int>(type: "int", nullable: false),
                    VideoContentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileVideoContent", x => new { x.ProfilesId, x.VideoContentsId });
                    table.ForeignKey(
                        name: "FK_ProfileVideoContent_Profiles_ProfilesId",
                        column: x => x.ProfilesId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileVideoContent_VideoContents_VideoContentsId",
                        column: x => x.VideoContentsId,
                        principalTable: "VideoContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistVideoContent_VideoContentsId",
                table: "PlaylistVideoContent",
                column: "VideoContentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileVideoContent_VideoContentsId",
                table: "ProfileVideoContent",
                column: "VideoContentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistVideoContent");

            migrationBuilder.DropTable(
                name: "ProfileVideoContent");

            migrationBuilder.CreateTable(
                name: "PlaybackHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    VideoContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaybackHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaybackHistories_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaybackHistories_VideoContents_VideoContentId",
                        column: x => x.VideoContentId,
                        principalTable: "VideoContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaybackHistories_ProfileId",
                table: "PlaybackHistories",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaybackHistories_VideoContentId",
                table: "PlaybackHistories",
                column: "VideoContentId");
        }
    }
}
