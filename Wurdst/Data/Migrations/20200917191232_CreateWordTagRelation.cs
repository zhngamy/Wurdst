using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wurdst.Data.Migrations
{
    public partial class CreateWordTagRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordTags",
                columns: table => new
                {
                    WordId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false),
                    WhenCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordTags", x => new { x.WordId, x.TagId });
                    table.ForeignKey(
                        name: "FK_WordTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordTags_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "WordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordTags_TagId",
                table: "WordTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordTags");
        }
    }
}
