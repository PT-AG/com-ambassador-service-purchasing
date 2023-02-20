using Com.Ambassador.Service.Purchasing.Lib.Helpers;
using Com.Ambassador.Service.Purchasing.Lib.Interfaces;
using Com.Ambassador.Service.Purchasing.Lib.Models.UnitReceiptNoteModel;
using Com.Ambassador.Service.Purchasing.Lib.Services;
using Com.Ambassador.Service.Purchasing.Lib.Utilities.Currencies;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentReports;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Purchasing.Lib.Facades.GarmentReports
{
    public class GarmentImportPurchasingJournalReportFacade : IGarmentImportPurchasingJournalReportFacade
    {
        private readonly PurchasingDbContext dbContext;
        public readonly IServiceProvider serviceProvider;
        private readonly DbSet<UnitReceiptNote> dbSet;
        private readonly ICurrencyProvider _currencyProvider;
        private readonly IdentityService _identityService;
        private readonly string IDRCurrencyCode = "IDR";

        public static readonly string[] MONTH_NAMES = { "JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER" };

        public GarmentImportPurchasingJournalReportFacade(IServiceProvider serviceProvider, PurchasingDbContext dbContext)
        {
            this.serviceProvider = serviceProvider;
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<UnitReceiptNote>();
            _currencyProvider = (ICurrencyProvider)serviceProvider.GetService(typeof(ICurrencyProvider));
            _identityService = serviceProvider.GetService<IdentityService>();
        }


        //public List<GarmentLocalPurchasingJournalReportViewModel> GetReportQuery(int month, int year, int offset)
        public List<GarmentImportPurchasingJournalReportViewModel> GetReportQuery(DateTime? dateFrom, DateTime? dateTo, int offset)
        {

            //DateTime dateFrom = new DateTime(year, month, 1);
            //int nextYear = month == 12 ? year + 1 : year;
            //int nextMonth = month == 12 ? 1 : month + 1;
            //DateTime dateTo = new DateTime(nextYear, nextMonth, 1);

            DateTime DateFrom = dateFrom == null ? new DateTime(1970, 1, 1) : (DateTime)dateFrom;
            DateTime DateTo = dateTo == null ? DateTime.Now : (DateTime)dateTo;

            List<GarmentImportPurchasingJournalReportViewModel> data = new List<GarmentImportPurchasingJournalReportViewModel>();

            var Query = (from a in dbContext.GarmentUnitReceiptNotes
                         join b in dbContext.GarmentUnitReceiptNoteItems on a.Id equals b.URNId
                         join e in dbContext.GarmentDeliveryOrderDetails on b.DODetailId equals e.Id
                         join d in dbContext.GarmentDeliveryOrderItems on e.GarmentDOItemId equals d.Id
                         join c in dbContext.GarmentDeliveryOrders on d.GarmentDOId equals c.Id
                         where a.URNType == "PEMBELIAN" && c.SupplierIsImport == true
                               && (c.PaymentType == "T/T AFTER" || c.PaymentType == "T/T BEFORE" || c.PaymentType == "CASH")
                               && c.DOCurrencyCode != "IDR"
                               && a.CreatedUtc.AddHours(offset).Date >= DateFrom.Date && a.CreatedUtc.AddHours(offset).Date <= DateTo.Date
                         group new { Price = b.PricePerDealUnit, Qty = b.ReceiptQuantity, Rate = c.DOCurrencyRate } by new { e.CodeRequirment, c.PaymentType, c.UseVat, c.VatRate, c.UseIncomeTax, c.IncomeTaxRate } into G

                         select new GarmentImportPurchasingJournalReportTempViewModel
                         {
                             Code = G.Key.CodeRequirment,
                             PaymentType = G.Key.PaymentType,
                             IsVat = G.Key.UseVat == true ? "Y" : "N",
                             VatRate = (double)G.Key.VatRate,
                             IsTax = G.Key.UseIncomeTax == true ? "Y" : "N",
                             TaxRate = (double)G.Key.IncomeTaxRate,
                             Amount = Math.Round(G.Sum(c => c.Price * c.Qty * (decimal)c.Rate), 2)
                         });

            var Query1 = (from x in Query
                          group new { Amt = x.Amount } by new { x.Code } into G

                          select new GarmentImportPurchasingJournalReportTemp1ViewModel
                          {
                              Code = G.Key.Code,
                              Amount = Math.Round(G.Sum(c => c.Amt), 2)
                          });

            var NewQuery = from a in Query1
                           select new GarmentImportPurchasingJournalReportViewModel
                           {
                               remark = a.Code == "BB" ? "PERSEDIAAN BAHAN BAKU(AG2)" : (a.Code == "BP" ? "PERSEDIAAN PEMBANTU(AG2)" : "PERSEDIAAN EMBALANCE(AG2)"),
                               credit = 0,
                               debit = a.Amount,
                               account = a.Code == "BB" ? "114.03.2.000" : (a.Code == "BP" ? "114.04.2.000" : "114.05.2.000")
                           };

            var sumquery = NewQuery.ToList()
                   .GroupBy(x => new { x.remark, x.account }, (key, group) => new
                   {
                       Remark = key.remark,
                       Account = key.account,
                       Debit = group.Sum(s => s.debit)
                   }).OrderBy(a => a.Remark);
            foreach (var item in sumquery)
            {
                var result = new GarmentImportPurchasingJournalReportViewModel
                {
                    remark = item.Remark,
                    debit = item.Debit,
                    credit = 0,
                    account = item.Account
                };

                data.Add(result);
            }

            var PPNMsk = new GarmentImportPurchasingJournalReportViewModel
            {
                remark = "PPN MASUKAN (AG2)",
                debit = Query.Where(a => a.IsVat == "Y").Sum(a => a.Amount * (decimal)(a.VatRate / 100)),
                credit = 0,
                account = "117.01.2.000"
            };

            //if (PPNMsk.debit > 0)
            //{
            data.Add(PPNMsk);
            //}

            //var PPH = new GarmentImportPurchasingJournalReportViewModel
            //{
            //    remark = "       PPH  23   YMH DIBAYAR(AG2)",
            //    debit = 0,
            //    credit = Query.Where(a => a.IsTax == "Y").Sum(a => a.Amount * (decimal)(a.TaxRate / 100)),
            //    account = "217.03.2.000"
            //};

            //if (PPH.credit > 0)
            //{
            //data.Add(PPH);
            //}

            var Credit1 = new GarmentImportPurchasingJournalReportViewModel
            {
                remark = "       KAS  DITANGAN VALAS (AG2)",
                credit = Query.Where(a => a.PaymentType == "CASH").Sum(a => a.Amount),
                debit = 0,
                account = "111.01.2.002"
            };

            //if (Credit1.credit > 0)
            //{
            data.Add(Credit1);
            //}

            var Credit = new GarmentImportPurchasingJournalReportViewModel
            {
                remark = "       HUTANG USAHA IMPOR(AG2)",
                debit = 0,
                //credit = Query1.Sum(a => a.Amount) + PPNMsk.debit - (PPH.credit + Credit1.credit),
                credit = Query1.Sum(a => a.Amount) + PPNMsk.debit - Credit1.credit,
                //credit = Query.Where(a => a.PaymentType == "T/T AFTER" || a.PaymentType == "T/T BEFORE").Sum(a => a.Amount),
                account = "211.00.3.000"
            };

            //if (Credit.credit > 0)
            //{
            data.Add(Credit);
            //}

            var total = new GarmentImportPurchasingJournalReportViewModel
            {
                remark = "",
                debit = Query1.Sum(a => a.Amount) + PPNMsk.debit,
                //credit = Credit.credit + Credit1.credit + PPH.credit,
                credit = Credit.credit + Credit1.credit,
                account = "J U M L A H"
            };
            data.Add(total);
            return data;
        }

        public List<GarmentImportPurchasingJournalReportViewModel> GetReportData(DateTime? dateFrom, DateTime? dateTo, int offset)
        {
            var Query = GetReportQuery(dateFrom, dateTo, offset);
            return Query.ToList();
        }

        public MemoryStream GenerateExcel(DateTime? dateFrom, DateTime? dateTo, int offset)
        {
            DateTime DateFrom = dateFrom == null ? new DateTime(1970, 1, 1) : (DateTime)dateFrom;
            DateTime DateTo = dateTo == null ? DateTime.Now : (DateTime)dateTo;

            var Query = GetReportQuery(dateFrom, dateTo, offset);
            DataTable result = new DataTable();

            result.Columns.Add(new DataColumn() { ColumnName = "AKUN DAN KETERANGAN", DataType = typeof(string) });
            result.Columns.Add(new DataColumn() { ColumnName = "AKUN", DataType = typeof(string) });
            result.Columns.Add(new DataColumn() { ColumnName = "DEBET", DataType = typeof(string) });
            result.Columns.Add(new DataColumn() { ColumnName = "KREDIT", DataType = typeof(string) });

            ExcelPackage package = new ExcelPackage();

            //if (Query.ToArray().Count() == 0)
            //    result.Rows.Add("", "", "", "");
            //else

            if (Query.ToArray().Count() == 0)
            {
                result.Rows.Add("", "", 0, 0);
                bool styling = true;

                foreach (KeyValuePair<DataTable, String> item in new List<KeyValuePair<DataTable, string>>() { new KeyValuePair<DataTable, string>(result, "Territory") })
                {
                    var sheet = package.Workbook.Worksheets.Add(item.Value);

                    //string Bln = MONTH_NAMES[month - 1];

                    sheet.Column(1).Width = 50;
                    sheet.Column(2).Width = 15;
                    sheet.Column(3).Width = 20;
                    sheet.Column(4).Width = 20;

                    #region KopTable
                    sheet.Cells[$"A1:D1"].Value = "PT AMBASSADOR GARMINDO";
                    sheet.Cells[$"A1:D1"].Merge = true;
                    sheet.Cells[$"A1:D1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    sheet.Cells[$"A1:D1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A1:D1"].Style.Font.Bold = true;

                    sheet.Cells[$"A2:D2"].Value = "ACCOUNTING DEPT.";
                    sheet.Cells[$"A2:D2"].Merge = true;
                    sheet.Cells[$"A2:D2"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    sheet.Cells[$"A2:D2"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A2:D2"].Style.Font.Bold = true;

                    sheet.Cells[$"A4:D4"].Value = "IKHTISAR JURNAL";
                    sheet.Cells[$"A4:D4"].Merge = true;
                    sheet.Cells[$"A4:D4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Cells[$"A4:D4"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A4:D4"].Style.Font.Bold = true;

                    sheet.Cells[$"C5"].Value = "BUKU HARIAN";
                    sheet.Cells[$"C5"].Style.Font.Bold = true;
                    sheet.Cells[$"D5"].Value = ": PEMBELIAN IMPORT";
                    sheet.Cells[$"D5"].Style.Font.Bold = true;

                    sheet.Cells[$"C6"].Value = "PERIODE";
                    sheet.Cells[$"C6"].Style.Font.Bold = true;
                    sheet.Cells[$"D6"].Value = ": " + DateFrom.ToString("ddMMyyyy") + " S/D " + DateTo.ToString("ddMMyyyy");
                    sheet.Cells[$"D6"].Style.Font.Bold = true;

                    #endregion
                    sheet.Cells["A8"].LoadFromDataTable(item.Key, true, (styling == true) ? OfficeOpenXml.Table.TableStyles.Light16 : OfficeOpenXml.Table.TableStyles.None);

                    //sheet.Cells[sheet.Dimension.Address].AutoFitColumns();
                }
            }
            else
            {
                int index = 0;
                foreach (var d in Query)
                {
                    index++;

                    result.Rows.Add(d.remark, d.account, d.debit, d.credit);
                }

                bool styling = true;

                foreach (KeyValuePair<DataTable, String> item in new List<KeyValuePair<DataTable, string>>() { new KeyValuePair<DataTable, string>(result, "Territory") })
                {
                    var sheet = package.Workbook.Worksheets.Add(item.Value);
                    //string Bln = MONTH_NAMES[month - 1];

                    #region KopTable
                    sheet.Cells[$"A1:D1"].Value = "PT AMBASSADOR GARMINDO";
                    sheet.Cells[$"A1:D1"].Merge = true;
                    sheet.Cells[$"A1:D1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    sheet.Cells[$"A1:D1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A1:D1"].Style.Font.Bold = true;

                    sheet.Cells[$"A2:D2"].Value = "ACCOUNTING DEPT.";
                    sheet.Cells[$"A2:D2"].Merge = true;
                    sheet.Cells[$"A2:D2"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    sheet.Cells[$"A2:D2"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A2:D2"].Style.Font.Bold = true;

                    sheet.Cells[$"A4:D4"].Value = "IKHTISAR JURNAL";
                    sheet.Cells[$"A4:D4"].Merge = true;
                    sheet.Cells[$"A4:D4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    sheet.Cells[$"A4:D4"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    sheet.Cells[$"A4:D4"].Style.Font.Bold = true;

                    sheet.Cells[$"C5"].Value = "BUKU HARIAN";
                    sheet.Cells[$"C5"].Style.Font.Bold = true;
                    sheet.Cells[$"D5"].Value = ": PEMBELIAN IMPORT";
                    sheet.Cells[$"D5"].Style.Font.Bold = true;

                    sheet.Cells[$"C6"].Value = "PERIODE";
                    sheet.Cells[$"C6"].Style.Font.Bold = true;
                    sheet.Cells[$"D6"].Value = ": " + DateFrom.ToString("ddMMyyyy") + " S/D " + DateTo.ToString("ddMMyyyy");
                    sheet.Cells[$"D6"].Style.Font.Bold = true;

                    #endregion
                    sheet.Cells["A8"].LoadFromDataTable(item.Key, true, (styling == true) ? OfficeOpenXml.Table.TableStyles.Light16 : OfficeOpenXml.Table.TableStyles.None);

                    //sheet.Cells[sheet.Dimension.Address].AutoFitColumns();
                }
            }

            var stream = new MemoryStream();
            package.SaveAs(stream);

            return stream;
        }
    }
}