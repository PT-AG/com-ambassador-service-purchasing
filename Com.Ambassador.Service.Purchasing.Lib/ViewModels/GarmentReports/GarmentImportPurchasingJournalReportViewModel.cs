using Com.Ambassador.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentReports
{
    public class GarmentImportPurchasingJournalReportTempViewModel
    {
        public string Code { get; set; }
        public string PaymentType { get; set; }      
        public string IsVat { get; set; }
        public double VatRate { get; set; }
        public string IsTax { get; set; }
        public double TaxRate { get; set; }
        public decimal Amount { get; set; }      
    }

    public class GarmentImportPurchasingJournalReportTemp1ViewModel
    {
        public string Code { get; set; }
        public decimal Amount { get; set; }
    }

    public class GarmentImportPurchasingJournalReportViewModel
    {
        public string remark { get; set; }
        public string account { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
    }
}