﻿using Com.Ambassador.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.Models.GarmentUenUrnChangeDateHistory
{
    public class GarmentUenUrnChangeDateHistory : BaseModel
    {
        public string DocumentNo { get; set; }
        public DateTimeOffset DateOld { get; set; }
        public DateTimeOffset DateNow { get; set; }
    }
}
