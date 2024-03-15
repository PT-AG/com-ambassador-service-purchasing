using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Purchasing.Lib.Migrations
{
    public partial class AddTableReceiptSubcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RemainingQuantity",
                table: "GarmentPurchaseRequestItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "GarmentSubconDeliveryOrders",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    ArrivalDate = table.Column<DateTimeOffset>(nullable: false),
                    Article = table.Column<string>(nullable: true),
                    BeacukaiDate = table.Column<DateTimeOffset>(nullable: false),
                    BeacukaiNo = table.Column<string>(nullable: true),
                    BeacukaiType = table.Column<string>(nullable: true),
                    CostCalculationId = table.Column<long>(nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CustomsId = table.Column<long>(nullable: false),
                    DODate = table.Column<DateTimeOffset>(nullable: false),
                    DONo = table.Column<string>(maxLength: 255, nullable: true),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsReceived = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    ProductOwnerCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductOwnerId = table.Column<long>(maxLength: 255, nullable: false),
                    ProductOwnerName = table.Column<string>(maxLength: 1000, nullable: true),
                    RONo = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    UId = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconDeliveryOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitDeliveryOrders",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Article = table.Column<string>(maxLength: 1000, nullable: true),
                    CorrectionId = table.Column<long>(nullable: false),
                    CorrectionNo = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DOId = table.Column<long>(nullable: false),
                    DONo = table.Column<string>(maxLength: 255, nullable: true),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    OtherDescription = table.Column<string>(maxLength: 4000, nullable: true),
                    RONo = table.Column<string>(maxLength: 255, nullable: true),
                    StorageCode = table.Column<string>(maxLength: 255, nullable: true),
                    StorageId = table.Column<long>(nullable: false),
                    StorageName = table.Column<string>(maxLength: 1000, nullable: true),
                    StorageRequestCode = table.Column<string>(maxLength: 255, nullable: true),
                    StorageRequestId = table.Column<long>(nullable: false),
                    StorageRequestName = table.Column<string>(maxLength: 1000, nullable: true),
                    UENFromId = table.Column<long>(nullable: false),
                    UENFromNo = table.Column<string>(maxLength: 255, nullable: true),
                    UId = table.Column<string>(maxLength: 255, nullable: true),
                    UnitDODate = table.Column<DateTimeOffset>(nullable: false),
                    UnitDOFromId = table.Column<long>(nullable: false),
                    UnitDOFromNo = table.Column<string>(maxLength: 255, nullable: true),
                    UnitDONo = table.Column<string>(maxLength: 255, nullable: true),
                    UnitDOType = table.Column<string>(maxLength: 255, nullable: true),
                    UnitRequestCode = table.Column<string>(maxLength: 255, nullable: true),
                    UnitRequestId = table.Column<long>(nullable: false),
                    UnitRequestName = table.Column<string>(maxLength: 1000, nullable: true),
                    UnitSenderCode = table.Column<string>(maxLength: 255, nullable: true),
                    UnitSenderId = table.Column<long>(nullable: false),
                    UnitSenderName = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitDeliveryOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitExpenditureNotes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    ExpenditureDate = table.Column<DateTimeOffset>(nullable: false),
                    ExpenditureTo = table.Column<string>(maxLength: 1000, nullable: true),
                    ExpenditureType = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsPreparing = table.Column<bool>(nullable: false),
                    IsReceived = table.Column<bool>(nullable: false),
                    IsTransfered = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    StorageCode = table.Column<string>(maxLength: 255, nullable: true),
                    StorageId = table.Column<long>(nullable: false),
                    StorageName = table.Column<string>(maxLength: 1000, nullable: true),
                    StorageRequestCode = table.Column<string>(maxLength: 255, nullable: true),
                    StorageRequestId = table.Column<long>(nullable: false),
                    StorageRequestName = table.Column<string>(maxLength: 1000, nullable: true),
                    UENNo = table.Column<string>(maxLength: 255, nullable: true),
                    UId = table.Column<string>(maxLength: 255, nullable: true),
                    UnitDOId = table.Column<long>(nullable: false),
                    UnitDONo = table.Column<string>(maxLength: 255, nullable: true),
                    UnitRequestCode = table.Column<string>(maxLength: 255, nullable: true),
                    UnitRequestId = table.Column<long>(nullable: false),
                    UnitRequestName = table.Column<string>(maxLength: 1000, nullable: true),
                    UnitSenderCode = table.Column<string>(maxLength: 255, nullable: true),
                    UnitSenderId = table.Column<long>(nullable: false),
                    UnitSenderName = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitExpenditureNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitReceiptNotes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Article = table.Column<string>(nullable: true),
                    BeacukaiDate = table.Column<DateTimeOffset>(nullable: false),
                    BeacukaiNo = table.Column<string>(nullable: true),
                    BeacukaiType = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DOCurrencyRate = table.Column<double>(nullable: true),
                    DOId = table.Column<long>(nullable: false),
                    DONo = table.Column<string>(maxLength: 255, nullable: true),
                    DRId = table.Column<string>(nullable: true),
                    DRNo = table.Column<string>(nullable: true),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedReason = table.Column<string>(nullable: true),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    IsCorrection = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsStorage = table.Column<bool>(nullable: false),
                    IsUnitDO = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    ProductOwnerCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductOwnerId = table.Column<long>(nullable: false),
                    ProductOwnerName = table.Column<string>(maxLength: 1000, nullable: true),
                    RONo = table.Column<string>(maxLength: 255, nullable: true),
                    ReceiptDate = table.Column<DateTimeOffset>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    UId = table.Column<string>(maxLength: 255, nullable: true),
                    URNNo = table.Column<string>(maxLength: 255, nullable: true),
                    URNType = table.Column<string>(nullable: true),
                    UnitCode = table.Column<string>(maxLength: 255, nullable: true),
                    UnitId = table.Column<long>(nullable: false),
                    UnitName = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitReceiptNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconDeliveryOrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    BudgetQuantity = table.Column<double>(nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: true),
                    DOQuantity = table.Column<double>(nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    GarmentDOId = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    POSerialNumber = table.Column<string>(nullable: true),
                    PRItemId = table.Column<long>(nullable: false),
                    PricePerDealUnit = table.Column<double>(nullable: false),
                    ProductCode = table.Column<string>(maxLength: 100, nullable: true),
                    ProductId = table.Column<long>(maxLength: 100, nullable: false),
                    ProductName = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductRemark = table.Column<string>(nullable: true),
                    ReceiptQuantity = table.Column<decimal>(nullable: false),
                    UomId = table.Column<string>(maxLength: 100, nullable: true),
                    UomUnit = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconDeliveryOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GarmentSubconDeliveryOrderItems_GarmentSubconDeliveryOrders_GarmentDOId",
                        column: x => x.GarmentDOId,
                        principalTable: "GarmentSubconDeliveryOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitDeliveryOrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    BeacukaiDate = table.Column<DateTimeOffset>(nullable: false),
                    BeacukaiNo = table.Column<string>(nullable: true),
                    BeacukaiType = table.Column<string>(nullable: true),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DOCurrencyRate = table.Column<double>(nullable: true),
                    DOItemId = table.Column<long>(nullable: false),
                    DefaultDOQuantity = table.Column<double>(nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DesignColor = table.Column<string>(maxLength: 1000, nullable: true),
                    EPOItemId = table.Column<long>(nullable: false),
                    FabricType = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    POItemId = table.Column<long>(nullable: false),
                    POSerialNumber = table.Column<string>(maxLength: 255, nullable: true),
                    PRItemId = table.Column<long>(nullable: false),
                    PricePerDealUnit = table.Column<double>(nullable: false),
                    ProductCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductRemark = table.Column<string>(maxLength: 1000, nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    RONo = table.Column<string>(maxLength: 255, nullable: true),
                    ReturQuantity = table.Column<double>(nullable: false),
                    ReturUomId = table.Column<long>(nullable: true),
                    ReturUomUnit = table.Column<string>(maxLength: 255, nullable: true),
                    UId = table.Column<string>(maxLength: 255, nullable: true),
                    URNId = table.Column<long>(nullable: false),
                    URNItemId = table.Column<long>(nullable: false),
                    URNNo = table.Column<string>(maxLength: 255, nullable: true),
                    UnitDOId = table.Column<long>(nullable: false),
                    UomId = table.Column<long>(nullable: false),
                    UomUnit = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitDeliveryOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GarmentSubconUnitDeliveryOrderItems_GarmentSubconUnitDeliveryOrders_UnitDOId",
                        column: x => x.UnitDOId,
                        principalTable: "GarmentSubconUnitDeliveryOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitExpenditureNoteItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    BasicPrice = table.Column<decimal>(type: "decimal(38, 4)", nullable: false),
                    BeacukaiDate = table.Column<DateTimeOffset>(nullable: false),
                    BeacukaiNo = table.Column<string>(nullable: true),
                    BeacukaiType = table.Column<string>(nullable: true),
                    Conversion = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DOCurrencyRate = table.Column<double>(nullable: true),
                    DOItemId = table.Column<long>(nullable: false),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    EPOItemId = table.Column<long>(nullable: false),
                    FabricType = table.Column<string>(maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ItemStatus = table.Column<string>(maxLength: 25, nullable: true),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    POItemId = table.Column<long>(nullable: false),
                    POSerialNumber = table.Column<string>(maxLength: 255, nullable: true),
                    PRItemId = table.Column<long>(nullable: false),
                    PricePerDealUnit = table.Column<double>(nullable: false),
                    ProductCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 255, nullable: true),
                    ProductOwnerCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductOwnerId = table.Column<long>(nullable: false),
                    ProductRemark = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    RONo = table.Column<string>(maxLength: 255, nullable: true),
                    ReturQuantity = table.Column<double>(nullable: false),
                    UENId = table.Column<long>(nullable: false),
                    UId = table.Column<string>(maxLength: 255, nullable: true),
                    URNItemId = table.Column<long>(nullable: false),
                    UnitDOItemId = table.Column<long>(nullable: false),
                    UomId = table.Column<long>(nullable: false),
                    UomUnit = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitExpenditureNoteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GarmentSubconUnitExpenditureNoteItems_GarmentSubconUnitExpenditureNotes_UENId",
                        column: x => x.UENId,
                        principalTable: "GarmentSubconUnitExpenditureNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GarmentSubconUnitReceiptNoteItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Box = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Conversion = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    CorrectionConversion = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedUtc = table.Column<DateTime>(nullable: false),
                    DOItemId = table.Column<long>(nullable: false),
                    DOQuantity = table.Column<double>(nullable: false),
                    DRItemId = table.Column<string>(nullable: true),
                    DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    DeletedUtc = table.Column<DateTime>(nullable: false),
                    DesignColor = table.Column<string>(maxLength: 1000, nullable: true),
                    IsCorrection = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    LastModifiedUtc = table.Column<DateTime>(nullable: false),
                    Level = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<decimal>(nullable: false),
                    POSerialNumber = table.Column<string>(maxLength: 1000, nullable: true),
                    PricePerDealUnit = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    ProductCode = table.Column<string>(maxLength: 255, nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 1000, nullable: true),
                    ProductRemark = table.Column<string>(nullable: true),
                    Rack = table.Column<string>(nullable: true),
                    ReceiptCorrection = table.Column<decimal>(nullable: false),
                    ReceiptQuantity = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    RemainingQuantity = table.Column<decimal>(nullable: false),
                    SmallQuantity = table.Column<decimal>(nullable: false),
                    SmallUomId = table.Column<long>(nullable: false),
                    SmallUomUnit = table.Column<string>(maxLength: 1000, nullable: true),
                    StorageCode = table.Column<string>(maxLength: 255, nullable: true),
                    StorageId = table.Column<long>(nullable: false),
                    StorageName = table.Column<string>(maxLength: 1000, nullable: true),
                    UId = table.Column<string>(nullable: true),
                    URNId = table.Column<long>(nullable: false),
                    UomId = table.Column<long>(nullable: false),
                    UomUnit = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarmentSubconUnitReceiptNoteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GarmentSubconUnitReceiptNoteItems_GarmentSubconUnitReceiptNotes_URNId",
                        column: x => x.URNId,
                        principalTable: "GarmentSubconUnitReceiptNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GarmentSubconDeliveryOrderItems_GarmentDOId",
                table: "GarmentSubconDeliveryOrderItems",
                column: "GarmentDOId");

            migrationBuilder.CreateIndex(
                name: "IX_GarmentSubconUnitDeliveryOrderItems_UnitDOId",
                table: "GarmentSubconUnitDeliveryOrderItems",
                column: "UnitDOId");

            migrationBuilder.CreateIndex(
                name: "IX_GarmentSubconUnitExpenditureNoteItems_UENId",
                table: "GarmentSubconUnitExpenditureNoteItems",
                column: "UENId");

            migrationBuilder.CreateIndex(
                name: "IX_GarmentSubconUnitReceiptNoteItems_URNId",
                table: "GarmentSubconUnitReceiptNoteItems",
                column: "URNId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GarmentSubconDeliveryOrderItems");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitDeliveryOrderItems");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitExpenditureNoteItems");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitReceiptNoteItems");

            migrationBuilder.DropTable(
                name: "GarmentSubconDeliveryOrders");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitDeliveryOrders");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitExpenditureNotes");

            migrationBuilder.DropTable(
                name: "GarmentSubconUnitReceiptNotes");

            migrationBuilder.DropColumn(
                name: "RemainingQuantity",
                table: "GarmentPurchaseRequestItems");
        }
    }
}
