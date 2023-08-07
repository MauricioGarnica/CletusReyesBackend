using AutoMapper;
using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Product;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Raw_Material;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using CletusReyes.Models.DTO.Category;
using CletusReyes.Models.DTO.Product;
using CletusReyes.Models.DTO.Provider;
using CletusReyes.Models.DTO.Raw_Material;
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
            CreateMap<TblSize, AddSizeRequestDomainModel>().ReverseMap();
            CreateMap<TblSize, UpdateSizeRequestDomainModel>().ReverseMap();

            //Categories
            CreateMap<TblCategory, CategoryResponseDto>().ReverseMap();
            CreateMap<TblCategory, AddCategoryRequestDomainModel>().ReverseMap();
            CreateMap<TblCategory, UpdateCategoryRequestDomainModel>().ReverseMap();

            //Unit of measure
            CreateMap<TblUnitMeasure, UnitMeasureResponseDto>().ReverseMap();
            CreateMap<TblUnitMeasure, AddUnitMeasureRequestDomainModel>().ReverseMap();
            CreateMap<TblUnitMeasure, UpdateUnitMeasureRequestDomainModel>().ReverseMap();

            //Providers
            CreateMap<TblProvider, ProviderResponseDto>().ReverseMap();
            CreateMap<TblProvider, AddProviderRequestDomainModel>().ReverseMap();
            CreateMap<TblProvider, UpdateProviderRequestDomainModel>().ReverseMap();

            //Raw_Material
            CreateMap<TblRawMaterial, RawMaterialResponseDto>().ReverseMap();
            CreateMap<TblRawMaterial, AddRawMaterialRequestDomainModel>().ReverseMap();
            CreateMap<TblRawMaterial, UpdateRawMaterialRequestDomainModel>().ReverseMap();

            //Products
            CreateMap<TblProduct, ProductResponseDto>().ReverseMap();
            CreateMap<TblProduct, AddProductRequestDomainModel>().ReverseMap();
            CreateMap<TblProduct, AddProductImageRequestDomainModel>().ReverseMap();
        }
    }
}
