﻿using Com.Ambassador.Service.Purchasing.Lib.Models.GarmentExternalPurchaseOrderModel;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentExternalPurchaseOrderViewModel;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentExternalPurchaseOrderViewModel.Reports;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface IGarmentTotalPurchaseOrderFacade
    {
        List<TotalGarmentPurchaseBySupplierViewModel> GetTotalGarmentPurchaseBySupplierReport(string unit, bool jnsSpl, string payMtd, string category, DateTime? dateFrom, DateTime? dateTo, int offset);
        MemoryStream GenerateExcelTotalGarmentPurchaseBySupplier(string unit, bool jnsSpl, string payMtd, string category, DateTime? dateFrom, DateTime? dateTo, int offset);

    }
}
