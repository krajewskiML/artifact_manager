using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class AddUserDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperClassCategoryCategoryId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Attributes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StringValues_AttributeId",
                table: "StringValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Representatives_CategoryId",
                table: "Representatives",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatValuess_AttributeId",
                table: "FloatValuess",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributes_AttributeId",
                table: "CategoryAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SuperClassCategoryCategoryId",
                table: "Categories",
                column: "SuperClassCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_CategoryId",
                table: "Attributes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Categories_CategoryId",
                table: "Attributes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_SuperClassCategoryCategoryId",
                table: "Categories",
                column: "SuperClassCategoryCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_Attributes_AttributeId",
                table: "CategoryAttributes",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_Categories_CategoryId",
                table: "CategoryAttributes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FloatValuess_Attributes_AttributeId",
                table: "FloatValuess",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FloatValuess_Representatives_RepresentativeId",
                table: "FloatValuess",
                column: "RepresentativeId",
                principalTable: "Representatives",
                principalColumn: "RepresentativeId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Representatives_Categories_CategoryId",
                table: "Representatives",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StringValues_Attributes_AttributeId",
                table: "StringValues",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StringValues_Representatives_RepresentativeId",
                table: "StringValues",
                column: "RepresentativeId",
                principalTable: "Representatives",
                principalColumn: "RepresentativeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Categories_CategoryId",
                table: "Attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_SuperClassCategoryCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_Attributes_AttributeId",
                table: "CategoryAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_Categories_CategoryId",
                table: "CategoryAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_FloatValuess_Attributes_AttributeId",
                table: "FloatValuess");

            migrationBuilder.DropForeignKey(
                name: "FK_FloatValuess_Representatives_RepresentativeId",
                table: "FloatValuess");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Attributes_AttributeId",
                table: "IntegerValues");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Representatives_RepresentativeId",
                table: "IntegerValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Representatives_Categories_CategoryId",
                table: "Representatives");

            migrationBuilder.DropForeignKey(
                name: "FK_StringValues_Attributes_AttributeId",
                table: "StringValues");

            migrationBuilder.DropForeignKey(
                name: "FK_StringValues_Representatives_RepresentativeId",
                table: "StringValues");

            migrationBuilder.DropIndex(
                name: "IX_StringValues_AttributeId",
                table: "StringValues");

            migrationBuilder.DropIndex(
                name: "IX_Representatives_CategoryId",
                table: "Representatives");

            migrationBuilder.DropIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues");

            migrationBuilder.DropIndex(
                name: "IX_FloatValuess_AttributeId",
                table: "FloatValuess");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributes_AttributeId",
                table: "CategoryAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SuperClassCategoryCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_CategoryId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "SuperClassCategoryCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Attributes");
        }
    }
}
