using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Data.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Strudents",
                table: "Strudents");

            migrationBuilder.RenameTable(
                name: "Strudents",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Strudents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strudents",
                table: "Strudents",
                column: "Id");
        }
    }
}
