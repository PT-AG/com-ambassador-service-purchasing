﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Ambassador.Service.Purchasing.Lib.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Com.Ambassador.Service.Purchasing.Lib.Models;
using Com.Ambassador.Service.Purchasing.Lib;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels;
using System.IO;
using Com.Ambassador.Service.Purchasing.Lib.Facades;
using Com.Ambassador.Service.Purchasing.Lib.Facades.ExternalPurchaseOrderFacade;
using Com.Ambassador.Service.Purchasing.WebApi.Helpers;

namespace Com.Ambassador.Service.Sales.WebApi.Controllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/generating-data/purchase-order-external")]
    [Authorize]
    public class ExternalPurchaseOrderGenerateDataController : Controller
    {

        private string ApiVersion = "1.0.0";
        private readonly ExternalPurchaseOrderGenerateDataFacade _facade;
        //private readonly IdentityService identityService;
        public ExternalPurchaseOrderGenerateDataController(ExternalPurchaseOrderGenerateDataFacade facade)//, IdentityService identityService)
        {
            _facade = facade;
            //this.identityService = identityService;
        }

        //[HttpGet("display")]
        //public IActionResult GetDisplay(DateTime? dateFrom, DateTime? dateTo, int page, int size, string Order = "{}")
        //{
        //    int offset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
        //    string accept = Request.Headers["Accept"];

        //    try
        //    {

        //        var data = _facade.GetDisplayReport(dateFrom, dateTo, page, size, Order, offset);

        //        return Ok(new
        //        {
        //            apiVersion = ApiVersion,
        //            data = data.Item1,
        //            info = new { total = data.Item2 }
        //        });
        //    }
        //    catch (Exception e)
        //    {
        //        Dictionary<string, object> Result =
        //            new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
        //            .Fail();
        //        return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
        //    }
        //}

        [HttpGet("download")]
        public IActionResult GetXls(DateTime? dateFrom, DateTime? dateTo)
        {
            try
            {
                int offset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
                string accept = Request.Headers["Accept"];
                byte[] xlsInBytes;
                DateTime DateFrom = dateFrom == null ? new DateTime(1970, 1, 1) : Convert.ToDateTime(dateFrom);
                DateTime DateTo = dateTo == null ? DateTime.Now : Convert.ToDateTime(dateTo);

                var xls = _facade.GenerateExcel(dateFrom, dateTo, offset);

                string filename = String.Format("Purchase Order External - {0}.xlsx", DateTime.UtcNow.ToString("ddMMyyyy"));

                xlsInBytes = xls.ToArray();
                var file = File(xlsInBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
                return file;

            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }
    }
}