using Com.Ambassador.Service.Purchasing.Lib.Utilities;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel.CostCalculationGarment
{
    public class CostCalculationGarmentViewModel : BaseViewModel
    {
        public string RO_Number { get; set; }
        public int Quantity { get; set; }
        public List<CostCalculationGarment_MaterialViewModel> CostCalculationGarment_Materials { get; set; }
    }
}
