using System;
using System.IO;

namespace Com.Ambassador.Service.Purchasing.Lib.Facades.BudgetCashflowService.ExcelGenerator
{
    public interface IBudgetCashflowUnitExcelGenerator
    {
        MemoryStream Generate(int unitId, DateTimeOffset dueDate);
    }
}
