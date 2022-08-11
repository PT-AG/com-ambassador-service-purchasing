﻿// <auto-generated />
using Com.Ambassador.Service.Purchasing.Lib;
using Com.Ambassador.Service.Purchasing.Lib.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Ambassador.Service.Purchasing.Lib.Migrations
{
    [DbContext(typeof(PurchasingDbContext))]
    [Migration("20180607020623_init EPO")]
    partial class initEPO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.Expedition.PurchasingDocumentExpedition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BankExpenditureNoteNo")
                        .HasMaxLength(255);

                    b.Property<string>("CashierDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("CashierDivisionDate");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("Currency")
                        .HasMaxLength(255);

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("DueDate");

                    b.Property<string>("FinanceDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("FinanceDivisionDate");

                    b.Property<string>("InvoiceNo")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("NotVerifiedReason")
                        .HasMaxLength(255);

                    b.Property<int>("Position");

                    b.Property<string>("SendToCashierDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToCashierDivisionDate");

                    b.Property<string>("SendToFinanceDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToFinanceDivisionDate");

                    b.Property<string>("SendToPurchasingDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToPurchasingDivisionDate");

                    b.Property<string>("SendToVerificationDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToVerificationDivisionDate");

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(255);

                    b.Property<double>("TotalPaid");

                    b.Property<DateTimeOffset>("UPODate");

                    b.Property<string>("UnitPaymentOrderNo")
                        .HasMaxLength(255);

                    b.Property<string>("VerificationDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("VerificationDivisionDate");

                    b.Property<DateTimeOffset?>("VerifyDate");

                    b.HasKey("Id");

                    b.ToTable("PurchasingDocumentExpeditions");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(255);

                    b.Property<string>("CurrencyId")
                        .HasMaxLength(255);

                    b.Property<string>("CurrencyRate")
                        .HasMaxLength(1000);

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<DateTimeOffset>("DeliveryDate");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionId")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(1000);

                    b.Property<string>("EPONo")
                        .HasMaxLength(255);

                    b.Property<string>("FreightCostBy");

                    b.Property<bool>("IsCanceled");

                    b.Property<bool>("IsClosed");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPosted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<DateTimeOffset>("OrderDate");

                    b.Property<string>("PaymentDueDays");

                    b.Property<string>("PaymentMethod");

                    b.Property<string>("Remark");

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierId")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(1000);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitName")
                        .HasMaxLength(1000);

                    b.Property<bool>("UseIncomeTax");

                    b.Property<bool>("UseVat");

                    b.Property<string>("VatId")
                        .HasMaxLength(255);

                    b.Property<string>("VatName")
                        .HasMaxLength(255);

                    b.Property<string>("VatRate")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("ExternalPurchaseOrders");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("Conversion");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<double>("DOQuantity");

                    b.Property<double>("DealQuantity");

                    b.Property<string>("DealUomId");

                    b.Property<string>("DealUomUnit");

                    b.Property<double>("DefaultQuantity");

                    b.Property<string>("DefaultUomId");

                    b.Property<string>("DefaultUomUnit");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<long>("EPOItemId");

                    b.Property<bool>("IncludePpn");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<long>("POItemId");

                    b.Property<long>("PRItemId");

                    b.Property<double>("PriceBeforeTax");

                    b.Property<double>("PricePerDealUnit");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductId")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasMaxLength(4000);

                    b.Property<string>("ProductRemark");

                    b.Property<double>("ReceiptQuantity");

                    b.HasKey("Id");

                    b.HasIndex("EPOItemId");

                    b.ToTable("ExternalPurchaseOrderDetails");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<long>("EPOId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<long>("POId");

                    b.Property<string>("PONo")
                        .HasMaxLength(255);

                    b.Property<long>("PRId");

                    b.Property<string>("PRNo")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitName")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("EPOId");

                    b.ToTable("ExternalPurchaseOrderItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.InternalPurchaseOrderModel.InternalPurchaseOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BudgetCode")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetId")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetName")
                        .HasMaxLength(1000);

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryId")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionId")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(1000);

                    b.Property<DateTimeOffset>("ExpectedDeliveryDate");

                    b.Property<bool>("IsClosed");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPosted");

                    b.Property<string>("IsoNo")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("PONo")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("PRDate");

                    b.Property<string>("PRId")
                        .HasMaxLength(255);

                    b.Property<string>("PRNo")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(255);

                    b.Property<string>("Status")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitName")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("InternalPurchaseOrders");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.InternalPurchaseOrderModel.InternalPurchaseOrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<long>("POId");

                    b.Property<string>("PRItemId")
                        .HasMaxLength(255);

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductId")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasMaxLength(4000);

                    b.Property<string>("ProductRemark")
                        .HasMaxLength(1000);

                    b.Property<long>("Quantity");

                    b.Property<string>("Status")
                        .HasMaxLength(255);

                    b.Property<string>("UomId")
                        .HasMaxLength(255);

                    b.Property<string>("UomUnit")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("POId");

                    b.ToTable("InternalPurchaseOrderItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BudgetCode")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetId")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetName")
                        .HasMaxLength(1000);

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryId")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionId")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(1000);

                    b.Property<DateTimeOffset>("ExpectedDeliveryDate");

                    b.Property<bool>("Internal");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPosted");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("No")
                        .HasMaxLength(255);

                    b.Property<string>("Remark");

                    b.Property<int>("Status");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitName")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequestItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductId")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasMaxLength(4000);

                    b.Property<long>("PurchaseRequestId");

                    b.Property<long>("Quantity");

                    b.Property<string>("Remark");

                    b.Property<string>("Status");

                    b.Property<string>("Uom")
                        .HasMaxLength(255);

                    b.Property<string>("UomId");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseRequestId");

                    b.ToTable("PurchaseRequestItems");
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrderDetail", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrderItem", "ExternalPurchaseOrderItem")
                        .WithMany("Details")
                        .HasForeignKey("EPOItemId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrderItem", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel.ExternalPurchaseOrder", "ExternalPurchaseOrder")
                        .WithMany("Items")
                        .HasForeignKey("EPOId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.InternalPurchaseOrderModel.InternalPurchaseOrderItem", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Purchasing.Lib.Models.InternalPurchaseOrderModel.InternalPurchaseOrder", "InternalPurchaseOrder")
                        .WithMany("Items")
                        .HasForeignKey("POId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Com.Ambassador.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequestItem", b =>
                {
                    b.HasOne("Com.Ambassador.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequest", "PurchaseRequest")
                        .WithMany("Items")
                        .HasForeignKey("PurchaseRequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
