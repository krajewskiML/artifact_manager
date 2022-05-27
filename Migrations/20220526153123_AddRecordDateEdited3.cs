using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class AddRecordDateEdited3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Representatives");*/

            migrationBuilder.AddColumn<string>(
                name: "DateModified2",
                table: "Representatives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified2",
                table: "Representatives");

            /*migrationBuilder.AddColumn<string>(
                name: "DateModified",
                table: "Representatives",
                type: "nvarchar(max)",
                nullable: true);*/
        }
    }
}
