using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShortLinkGenerator.EF.Persistence.Migrations
{
    public partial class addModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "URL");

            migrationBuilder.CreateTable(
                name: "Url",
                schema: "URL",
                columns: table => new
                {
                    UrlId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(maxLength: 2048, nullable: false),
                    LinkCode = table.Column<string>(nullable: true),
                    ShortLink = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.UrlId);
                });

            migrationBuilder.CreateTable(
                name: "UrlVisitorsCounters",
                schema: "URL",
                columns: table => new
                {
                    CounterId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<long>(nullable: false),
                    LinkCode = table.Column<string>(nullable: true),
                    LastVisited = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlVisitorsCounters", x => x.CounterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Url",
                schema: "URL");

            migrationBuilder.DropTable(
                name: "UrlVisitorsCounters",
                schema: "URL");
        }
    }
}
