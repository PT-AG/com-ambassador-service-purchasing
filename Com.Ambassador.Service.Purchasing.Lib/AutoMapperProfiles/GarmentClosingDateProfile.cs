using AutoMapper;
using Com.Ambassador.Service.Purchasing.Lib.Models.GarmentClosingDateModels;
using Com.Ambassador.Service.Purchasing.Lib.ViewModels.GarmentClosingDateViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Purchasing.Lib.AutoMapperProfiles
{
    public class GarmentClosingDateProfile : Profile
    {
        public GarmentClosingDateProfile()
        {
            CreateMap<GarmentClosingDate, GarmentClosingDateViewModel>()
              .ReverseMap();
        }
    }
}
