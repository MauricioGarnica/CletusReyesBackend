using AutoMapper;
using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using CletusReyes.Models.DTO.Category;
using CletusReyes.Models.DTO.Provider;
using CletusReyes.Models.DTO.Size;
using CletusReyes.Models.DTO.Unit_Measure;

namespace CletusReyes.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Sizes
            CreateMap<TblSize, SizeResponseDto>().ReverseMap();

            //Categories
            CreateMap<TblCategory, CategoryResponseDto>().ReverseMap();

            //Unit of measure
            CreateMap<TblUnitMeasure, UnitMeasureResponseDto>().ReverseMap();
            CreateMap<TblUnitMeasure, AddUnitMeasureRequestDomainModel>().ReverseMap();
            CreateMap<TblUnitMeasure, UpdateUnitMeasureRequestDomainModel>().ReverseMap();

            //Providers
            CreateMap<TblProvider, ProviderResponseDto>().ReverseMap();
            CreateMap<TblProvider, AddProviderRequestDomainModel>().ReverseMap();
            CreateMap<TblProvider, UpdateProviderRequestDomainModel>().ReverseMap();
        }
    }
}
