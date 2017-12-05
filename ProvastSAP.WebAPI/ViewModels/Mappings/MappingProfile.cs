using AutoMapper;
using ProvastSAP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvastSAP.WebAPI.ViewModels.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FacilityVM, Facility>();
            CreateMap<Facility, FacilityVM>();
            CreateMap<FacilityVM, Facility>().ReverseMap();
            CreateMap<Facility, FacilityVM>().ReverseMap();

            CreateMap<FlatTypeVM, FlatType>();
            CreateMap<FlatType, FlatTypeVM>();
            CreateMap<FlatTypeVM, FlatType>().ReverseMap();
            CreateMap<FlatType, FlatTypeVM>().ReverseMap();

            CreateMap<FloorVM, Floor>();
            CreateMap<Floor, FloorVM>();
            CreateMap<FloorVM, Floor>().ReverseMap();
            CreateMap<Floor, FloorVM>().ReverseMap();

            CreateMap<SiteTypeVM, SiteType>();
            CreateMap<SiteType, SiteTypeVM>();
            CreateMap<SiteTypeVM, SiteType>().ReverseMap();
            CreateMap<SiteType, SiteTypeVM>().ReverseMap();

            CreateMap<SiteVM, Site>();
            CreateMap<Site, SiteVM>();
            CreateMap<SiteVM, Site>().ReverseMap();
            CreateMap<Site, SiteVM>().ReverseMap();

        }
        
    }
}
