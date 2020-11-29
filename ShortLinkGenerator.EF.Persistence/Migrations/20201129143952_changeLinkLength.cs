using Microsoft.EntityFrameworkCore.Migrations;

namespace ShortLinkGenerator.EF.Persistence.Migrations
{
    public partial class changeLinkLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortLink",
                schema: "URL",
                table: "Url",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                schema: "URL",
                table: "Url",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2048);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortLink",
                schema: "URL",
                table: "Url",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                schema: "URL",
                table: "Url",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
