using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerApi.Migrations
{
    public partial class DBFix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_Cart",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Cart",
                table: "Carts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Cart",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CartId",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                newName: "IX_Carts_Cart");

            migrationBuilder.AlterColumn<Guid>(
                name: "CartId",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_Cart",
                table: "Carts",
                column: "Cart",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }
    }
}
