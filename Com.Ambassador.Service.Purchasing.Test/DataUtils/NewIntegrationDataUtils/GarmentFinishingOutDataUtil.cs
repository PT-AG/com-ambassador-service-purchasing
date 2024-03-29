﻿using Com.Ambassador.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel.GarmentFinishingOut;
using Com.Ambassador.Service.Purchasing.WebApi.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Test.DataUtils.NewIntegrationDataUtils
{
    public class GarmentFinishingOutDataUtil
    {
        public GarmentFinishingOutViewModel GetNewData()
        {
            long nowTicks = DateTimeOffset.Now.Ticks;

            var data = new GarmentFinishingOutViewModel
            {
                finishingInType = "",
                finishingTo = "GUDANG JADI",
                roJob = "RONo123",
                totalQty = 12
            };
            return data;
        }

        public Dictionary<string, object> GetResultFormatterOk()
        {
            return GetResultFormatterOk(GetNewData());
        }

        public Dictionary<string, object> GetResultFormatterOk(GarmentFinishingOutViewModel garmentExpenditureGoodViewModel)
        {
            var data = garmentExpenditureGoodViewModel;

            Dictionary<string, object> result =
                new ResultFormatter("1.0", General.OK_STATUS_CODE, General.OK_MESSAGE)
                .Ok(data);

            return result;
        }

        public string GetResultFormatterOkString()
        {
            return GetResultFormatterOkString(GetNewData());
        }

        public string GetResultFormatterOkString(GarmentFinishingOutViewModel garmentExpenditureGoodViewModel)
        {
            var result = GetResultFormatterOk(garmentExpenditureGoodViewModel);

            return JsonConvert.SerializeObject(result);
        }
        public Dictionary<string, object> GetMultipleResultFormatterOk()
        {
            var data = new List<GarmentFinishingOutViewModel> { GetNewData() };

            Dictionary<string, object> result =
                new ResultFormatter("1.0", General.OK_STATUS_CODE, General.OK_MESSAGE)
                .Ok(data);

            return result;
        }

        public string GetMultipleResultFormatterOkString()
        {
            var result = GetMultipleResultFormatterOk();

            return JsonConvert.SerializeObject(result);
        }

        public Dictionary<string, object> GetNullFormatterOk()
        {
            //List<GarmentExpenditureGoodViewModel> garmentExpenditureGoods = new List<GarmentExpenditureGoodViewModel>();
            //garmentExpenditureGoods.Add(GetNewData());
            //garmentExpenditureGoods.Add(GetNewData());
            //var data = new List<GarmentExpenditureGoodViewModel> { GetNewData() };

            Dictionary<string, object> result =
                new ResultFormatter("1.0", General.OK_STATUS_CODE, General.OK_MESSAGE)
                .Ok(null);

            return result;
        }

        public string GetNullFormatterOkString()
        {
            var result = GetNullFormatterOk();

            return JsonConvert.SerializeObject(result);
        }
    }
}
