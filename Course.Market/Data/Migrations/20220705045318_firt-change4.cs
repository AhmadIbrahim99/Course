using Microsoft.EntityFrameworkCore.Migrations;

namespace Course.Market.Data.Migrations
{
    public partial class firtchange4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Shopper_ShopperId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shopper",
                table: "Shopper");

            migrationBuilder.RenameTable(
                name: "Shopper",
                newName: "Shoppers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoppers",
                table: "Shoppers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Shoppers_ShopperId",
                table: "Carts",
                column: "ShopperId",
                principalTable: "Shoppers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Shoppers_ShopperId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoppers",
                table: "Shoppers");

            migrationBuilder.RenameTable(
                name: "Shoppers",
                newName: "Shopper");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shopper",
                table: "Shopper",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Shopper_ShopperId",
                table: "Carts",
                column: "ShopperId",
                principalTable: "Shopper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
