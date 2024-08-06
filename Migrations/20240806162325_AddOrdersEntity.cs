using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barford_Inventory_System.Migrations
{
    /// <inheritdoc />
    public partial class AddOrdersEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: false),
                    InDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OutDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDTOGroupId = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderGroupId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Item_Order_OrderGroupId",
                        column: x => x.OrderGroupId,
                        principalTable: "Order",
                        principalColumn: "GroupId");
                    table.ForeignKey(
                        name: "FK_Item_Orders_OrderDTOGroupId",
                        column: x => x.OrderDTOGroupId,
                        principalTable: "Orders",
                        principalColumn: "GroupId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_OrderDTOGroupId",
                table: "Item",
                column: "OrderDTOGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_OrderGroupId",
                table: "Item",
                column: "OrderGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
