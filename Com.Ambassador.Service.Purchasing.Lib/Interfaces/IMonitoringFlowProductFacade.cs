using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface IMonitoringFlowProductFacade
    {
        Tuple<List<MonitoringFlowProductViewModel>, int> GetFlow(string Dono, string beacukaiNo, string ProductCode);
        MemoryStream GetProductFlowExcel(string Dono, string beacukaiNo, string ProductCode);
    }
}
