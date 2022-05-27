using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class AddIntegerForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues",
                column: "AttributeId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Attributes_AttributeId",
                table: "IntegerValues");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegerValues_Representatives_RepresentativeId",
                table: "IntegerValues");

            migrationBuilder.DropIndex(
                name: "IX_IntegerValues_AttributeId",
                table: "IntegerValues");
        }
    }
}
