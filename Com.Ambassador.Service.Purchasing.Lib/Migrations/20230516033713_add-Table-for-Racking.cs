using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Purchasing.Lib.Migrations
{
    public partial class addTableforRacking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "GarmentUnitReceiptNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Box",
                table: "GarmentUnitReceiptNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "GarmentUnitReceiptNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "GarmentUnitReceiptNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "GarmentUnitReceiptNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "GarmentUnitExpenditureNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Box",
                table: "GarmentUnitExpenditureNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "GarmentUnitExpenditureNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "GarmentUnitExpenditureNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "GarmentUnitExpenditureNoteItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "GarmentUnitDeliveryOrderItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Box",
                table: "GarmentUnitDeliveryOrderItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "GarmentUnitDeliveryOrderItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "GarmentUnitDeliveryOrderItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "GarmentUnitDeliveryOrderItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "GarmentDOItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Box",
                table: "GarmentDOItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "GarmentDOItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "GarmentDOItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "GarmentDOItems",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SplitQuantity",
                table: "GarmentDOItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "GarmentUnitReceiptNoteItems");

            migrationBuilder.DropColumn(
                name: "Box",
                table: "GarmentUnitReceiptNoteItems");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "GarmentUnitReceiptNoteItems");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "GarmentUnitReceiptNoteItems");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "GarmentUnitReceiptNoteItems");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "GarmentUnitExpenditureNoteItems");

            migrationBuilder.DropColumn(
                name: "Box",
                table: "GarmentUnitExpenditureNoteItems");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "GarmentUnitExpenditureNoteItems");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "GarmentUnitExpenditureNoteItems");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "GarmentUnitExpenditureNoteItems");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "GarmentUnitDeliveryOrderItems");

            migrationBuilder.DropColumn(
                name: "Box",
                table: "GarmentUnitDeliveryOrderItems");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "GarmentUnitDeliveryOrderItems");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "GarmentUnitDeliveryOrderItems");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "GarmentUnitDeliveryOrderItems");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "GarmentDOItems");

            migrationBuilder.DropColumn(
                name: "Box",
                table: "GarmentDOItems");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "GarmentDOItems");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "GarmentDOItems");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "GarmentDOItems");

            migrationBuilder.DropColumn(
                name: "SplitQuantity",
                table: "GarmentDOItems");
        }
    }
}
