using Microsoft.EntityFrameworkCore.Migrations;

namespace artifact_manager2.Migrations
{
    public partial class ChangeSuperClassIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperClass",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "SuperClassId",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperClassId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "SuperClass",
                table: "Categories",
                type: "int",
                nullable: true);
        }
    }
}
