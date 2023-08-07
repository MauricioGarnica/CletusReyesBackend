using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.DTO.Category;
using CletusReyes.Repositories.Category;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var categoryDomainMode = await categoryRepository.GetAll();

                return Ok(mapper.Map<List<CategoryResponseDto>>(categoryDomainMode));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            try
            {
                var categoriesDomainModel = await categoryRepository.GetById(id);

                if (categoriesDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<CategoryResponseDto>(categoriesDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] AddCategoryRequestDomainModel addCategoryRequestDomainModel)
        {
            try
            {
                var categoryDomainModel = mapper.Map<TblCategory>(addCategoryRequestDomainModel);

                categoryDomainModel = await categoryRepository.Create(categoryDomainModel);

                return Ok(mapper.Map<CategoryResponseDto>(categoryDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ValidateModel]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCategoryRequestDomainModel updateCategoryRequestDomainModel)
        {
            try
            {
                var categoryDomainModel = mapper.Map<TblCategory>(updateCategoryRequestDomainModel);

                categoryDomainModel = await categoryRepository.Update(id, categoryDomainModel);

                if(categoryDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<CategoryResponseDto>(categoryDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            try
            {
                var categoryDomainModel = await categoryRepository.Delete(id);

                if(categoryDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<CategoryResponseDto>(categoryDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
