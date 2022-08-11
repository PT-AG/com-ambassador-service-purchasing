using Com.Ambassador.Service.Purchasing.Lib.Helpers.ReadResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface IPPHBankExpenditureNoteReportFacade
    {
        ReadResponse<object> GetReport(int Size, int Page, string No, string UnitPaymentOrderNo, string InvoiceNo, string SupplierCode, DateTimeOffset? DateFrom, DateTimeOffset? DateTo, int Offset);
    }
}
