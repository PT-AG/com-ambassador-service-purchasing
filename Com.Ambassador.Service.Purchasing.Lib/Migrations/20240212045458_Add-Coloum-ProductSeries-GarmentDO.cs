using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Purchasing.Lib.Migrations
{
    public partial class AddColoumProductSeriesGarmentDO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSeries",
                table: "GarmentDeliveryOrderDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductSeries",
                table: "GarmentDeliveryOrderDetails");
        }
    }
}
