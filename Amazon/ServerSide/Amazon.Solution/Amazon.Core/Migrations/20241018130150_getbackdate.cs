﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon.Core.Migrations
{
    /// <inheritdoc />
    public partial class getbackdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount_DiscountPercentage",
                table: "Products",
                type: "decimal(5,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Discount_DiscountStarted",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Discount_EndDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount_PriceAfterDiscount",
                table: "Products",
                type: "money",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Discount_StartDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewHeadLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReviewText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AppUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropColumn(
                name: "Discount_DiscountPercentage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount_DiscountStarted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount_EndDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount_PriceAfterDiscount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discount_StartDate",
                table: "Products");
        }
    }
}