using AutoMapper;
using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.DTO.Category;
using CletusReyes.Models.DTO.Size;

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
        }
    }
}
