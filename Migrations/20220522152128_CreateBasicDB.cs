using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class CreateBasicDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    AttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TypeOfAttribute = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.AttributeId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperClass = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryAttributes",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAttributes", x => new { x.CategoryId, x.AttributeId });
                });

            migrationBuilder.CreateTable(
                name: "FloatValuess",
                columns: table => new
                {
                    RepresentativeId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false),
                    Value = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatValuess", x => new { x.RepresentativeId, x.AttributeId });
                });

            migrationBuilder.CreateTable(
                name: "IntegerValues",
                columns: table => new
                {
                    RepresentativeId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegerValues", x => new { x.RepresentativeId, x.AttributeId });
                });

            migrationBuilder.CreateTable(
                name: "Representatives",
                columns: table => new
                {
                    RepresentativeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representatives", x => x.RepresentativeId);
                });

            migrationBuilder.CreateTable(
                name: "StringValues",
                columns: table => new
                {
                    RepresentativeId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringValues", x => new { x.RepresentativeId, x.AttributeId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryAttributes");

            migrationBuilder.DropTable(
                name: "FloatValuess");

            migrationBuilder.DropTable(
                name: "IntegerValues");

            migrationBuilder.DropTable(
                name: "Representatives");

            migrationBuilder.DropTable(
                name: "StringValues");
        }
    }
}
