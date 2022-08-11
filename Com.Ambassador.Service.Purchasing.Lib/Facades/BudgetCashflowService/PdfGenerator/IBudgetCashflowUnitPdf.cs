using System;
using System.IO;

namespace Com.Ambassador.Service.Purchasing.Lib.Facades.BudgetCashflowService.PdfGenerator
{
    public interface IBudgetCashflowUnitPdf
    {
        MemoryStream Generate(int unitId, DateTimeOffset dueDate);
    }
}
