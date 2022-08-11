using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentReports;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Interfaces
{
    public interface IBeacukaiNoFeature
    {
        List<BeacukaiNoFeatureViewModel> GetBeacukaiNo(string filter, string keyword);
    }
}
