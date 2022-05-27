using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class RemoveUnnecesarryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Attributes_AttributeId",
                table: "IntegerValues");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Representatives_RepresentativeId",
                table: "IntegerValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StringValues",
                table: "StringValues");

            migrationBuilder.DropIndex(
                name: "IX_StringValues_RepresentativeId",
                table: "StringValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegerValues",
                table: "IntegerValues");

            migrationBuilder.DropIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues");

            migrationBuilder.DropIndex(
                name: "IX_IntegerValues_RepresentativeId",
                table: "IntegerValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FloatValuess",
                table: "FloatValuess");

            migrationBuilder.DropIndex(
                name: "IX_FloatValuess_RepresentativeId",
                table: "FloatValuess");

            migrationBuilder.DropColumn(
                name: "StringValueId",
                table: "StringValues");

            migrationBuilder.DropColumn(
                name: "IntegerValueId",
                table: "IntegerValues");

            migrationBuilder.DropColumn(
                name: "FloatValueID",
                table: "FloatValuess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StringValues",
                table: "StringValues",
                columns: new[] { "RepresentativeId", "AttributeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegerValues",
                table: "IntegerValues",
                columns: new[] { "RepresentativeId", "AttributeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FloatValuess",
                table: "FloatValuess",
                columns: new[] { "RepresentativeId", "AttributeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StringValues",
                table: "StringValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegerValues",
                table: "IntegerValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FloatValuess",
                table: "FloatValuess");

            migrationBuilder.AddColumn<int>(
                name: "StringValueId",
                table: "StringValues",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IntegerValueId",
                table: "IntegerValues",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FloatValueID",
                table: "FloatValuess",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StringValues",
                table: "StringValues",
                column: "StringValueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegerValues",
                table: "IntegerValues",
                column: "IntegerValueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FloatValuess",
                table: "FloatValuess",
                column: "FloatValueID");

            migrationBuilder.CreateIndex(
                name: "IX_StringValues_RepresentativeId",
                table: "StringValues",
                column: "RepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegerValues_RepresentativeId",
                table: "IntegerValues",
                column: "RepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatValuess_RepresentativeId",
                table: "FloatValuess",
                column: "RepresentativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IntegerValues_Attributes_AttributeId",
                table: "IntegerValues",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegerValues_Representatives_RepresentativeId",
                table: "IntegerValues",
                column: "RepresentativeId",
                principalTable: "Representatives",
                principalColumn: "RepresentativeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
