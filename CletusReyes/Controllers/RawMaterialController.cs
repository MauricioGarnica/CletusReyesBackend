using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Raw_Material;
using CletusReyes.Models.DTO.Raw_Material;
using CletusReyes.Repositories.Raw_Material;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawMaterialController : ControllerBase
    {
        private readonly IRawMaterialRepository rawMaterialRepository;
        private readonly IMapper mapper;

        public RawMaterialController(IRawMaterialRepository rawMaterialRepository, IMapper mapper)
        {
            this.rawMaterialRepository = rawMaterialRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var rawMaterialDomainModel = await rawMaterialRepository.GetAll();

                return Ok(mapper.Map<List<RawMaterialResponseDto>>(rawMaterialDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById([FromRoute]Guid id)
        {
            try
            {
                var rawMaterialDomainModel = await rawMaterialRepository.GetById(id);

                if(rawMaterialDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RawMaterialResponseDto>(rawMaterialDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody]AddRawMaterialRequestDomainModel addRawMaterialRequestDomainModel)
        {
            try
            {
                var rawMaterialDomainModel = mapper.Map<TblRawMaterial>(addRawMaterialRequestDomainModel);
                rawMaterialDomainModel = await rawMaterialRepository.Create(rawMaterialDomainModel);

                return Ok(mapper.Map<RawMaterialResponseDto>(rawMaterialDomainModel));
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
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRawMaterialRequestDomainModel updateRawMaterialRequestDomainModel)
        {
            try
            {
                var rawMaterialDomainModel = mapper.Map<TblRawMaterial>(updateRawMaterialRequestDomainModel);
                rawMaterialDomainModel = await rawMaterialRepository.Update(id, rawMaterialDomainModel);

                if(rawMaterialDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RawMaterialResponseDto>(rawMaterialDomainModel));
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
                var rawMaterialDomainModel = await rawMaterialRepository.Delete(id);

                if(rawMaterialRepository == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RawMaterialResponseDto>(rawMaterialDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
