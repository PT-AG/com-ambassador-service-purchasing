using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentUnitReceiptNoteViewModels.DOItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentUnitReceiptNoteViewModels
{
    public class DOItemsRackingViewModels
    {
        public string POSerialNumber { get; set; }
        public List<RackingViewModels> Items { get; set; }

    }
}
