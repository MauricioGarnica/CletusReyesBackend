using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.DTO.Size;
using CletusReyes.Repositories.Size;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeRepository sizeRepository;
        private readonly IMapper mapper;

        public SizeController(ISizeRepository sizeRepository, IMapper mapper)
        {
            this.sizeRepository = sizeRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var sizesDomainModel = await sizeRepository.GetAllAsync();

                return Ok(mapper.Map<List<SizeResponseDto>>(sizesDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("id:Guid")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById([FromRoute]Guid id)
        {
            try
            {
                var sizesDomainModel = await sizeRepository.GetByIdAsync(id);

                if(sizesDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<SizeResponseDto>(sizesDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody]AddSizeRequestDomainModel addSizeRequestDomainModel)
        {
            try
            {
                var sizeDomainModel = mapper.Map<TblSize>(addSizeRequestDomainModel);

                await sizeRepository.Create(sizeDomainModel);

                return Ok(mapper.Map<SizeResponseDto>(sizeDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ValidateModel]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateSizeRequestDomainModel updateSizeRequestDomainModel)
        {
            try
            {
                var sizeDomainModel = mapper.Map<TblSize>(updateSizeRequestDomainModel);
                sizeDomainModel = await sizeRepository.Update(id, sizeDomainModel);

                if(sizeDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<SizeResponseDto>(sizeDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var sizeDomainModel = await sizeRepository.Delete(id);

                if(sizeDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<SizeResponseDto>(sizeDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
