﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.ViewModels.IntegrationViewModel
{
    public class UnitViewModel
    {
        public string _id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public DivisionViewModel division { get; set; }
    }
}
