using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Course.Market.Data.Migrations
{
    public partial class firtchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopperId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shopper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopper", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ShopperId",
                table: "Carts",
                column: "ShopperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Shopper_ShopperId",
                table: "Carts",
                column: "ShopperId",
                principalTable: "Shopper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Shopper_ShopperId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "Shopper");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ShopperId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ShopperId",
                table: "Carts");
        }
    }
}
