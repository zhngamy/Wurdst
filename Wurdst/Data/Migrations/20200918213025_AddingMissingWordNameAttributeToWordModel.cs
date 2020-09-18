using Microsoft.EntityFrameworkCore.Migrations;

namespace Wurdst.Data.Migrations
{
    public partial class AddingMissingWordNameAttributeToWordModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WordName",
                table: "Words",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WordName",
                table: "Words");
        }
    }
}
