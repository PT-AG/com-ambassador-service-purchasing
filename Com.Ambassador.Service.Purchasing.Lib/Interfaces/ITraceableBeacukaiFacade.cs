﻿using Com.Ambassador.Service.Purchasing.Lib.Helpers.ReadResponse;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface ITraceableBeacukaiFacade
    {
        Tuple<List<TraceableInBeacukaiViewModel>, int> GetReportTraceableIN(string filter, string tipe, string tipebc);
        MemoryStream GetTraceableInExcel(string filter, string tipe, string tipebc);
        //List<TraceableOutBeacukaiDetailViewModel> getQueryDetail(string RO);
        List<TraceableOutBeacukaiViewModel> getQueryTraceableOut(string bcno);
        MemoryStream GetExceltraceOut(string bcno);

        //ReadResponse<object> Read(string bum, int Page = 1, int Size = 25, string Order = "{}");

        List<TraceableInWithBUMBeacukaiViewModel> Read(string bum);
        MemoryStream GetExceltracebyBUM(string bum);
    }
}
