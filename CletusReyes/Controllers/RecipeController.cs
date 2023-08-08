using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Recipe;
using CletusReyes.Models.DTO.Recipe;
using CletusReyes.Repositories.Recipe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IMapper mapper;

        public RecipeController(IRecipeRepository recipeRepository, IMapper mapper)
        {
            this.recipeRepository = recipeRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var recipesDomainModel = await recipeRepository.GetAll();

                return Ok(mapper.Map<List<RecipeHeaderResponseDto>>(recipesDomainModel));
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
                var recipeExists = await recipeRepository.GetById(id);

                if(recipeExists == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RecipeResponseDto>(recipeExists));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody]AddRecipeHeaderRequestDomainModel addRecipeHeaderRequestDomainModel)
        {
            try
            {
                var recipeHeaderDomainModel = mapper.Map<TblRecipeHeader>(addRecipeHeaderRequestDomainModel);
                var recipeDetailsDomainModel = mapper.Map<List<TblRecipeDetail>>(addRecipeHeaderRequestDomainModel.Details);
                recipeHeaderDomainModel = await recipeRepository.Create(recipeHeaderDomainModel, recipeDetailsDomainModel);

                return Ok(mapper.Map<RecipeHeaderResponseDto>(recipeHeaderDomainModel));
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
                var recipeDeleted = await recipeRepository.Delete(id);

                if(recipeDeleted == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RecipeHeaderResponseDto>(recipeDeleted));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
