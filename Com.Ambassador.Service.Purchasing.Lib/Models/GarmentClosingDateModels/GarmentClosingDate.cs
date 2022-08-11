using Com.Ambassador.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Models.GarmentClosingDateModels
{
    public class GarmentClosingDate : BaseModel
    {
        public DateTimeOffset CloseDate { get; set; }
    }
}
