using Com.Ambassador.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentDeliveryOrderViewModel;

namespace Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentInvoiceViewModels
{
    public class GarmentInvoiceItemViewModel : BaseViewModel
    {
        public Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentDeliveryOrderViewModel.GarmentDeliveryOrderViewModel deliveryOrder { get; set; }
        public List<GarmentInvoiceDetailViewModel> details { get; set; }
	}
}
