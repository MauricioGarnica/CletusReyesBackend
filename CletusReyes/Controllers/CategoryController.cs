using AutoMapper;
using CletusReyes.Models.DTO.Category;
using CletusReyes.Repositories.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var categoryDomainMode = await categoryRepository.GetAll();

                return Ok(mapper.Map<List<CategoryResponseDto>>(categoryDomainMode));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("id:Guid")]
        public async Task<IActionResult> GetById([FromRoute]Guid id)
        {
            try
            {
                var categoriesDomainModel = await categoryRepository.GetById(id);

                if(categoriesDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<CategoryResponseDto>(categoriesDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
