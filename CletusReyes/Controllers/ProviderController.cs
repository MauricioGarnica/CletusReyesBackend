using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.DTO.Provider;
using CletusReyes.Repositories.Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderRepository providerRepository;
        private readonly IMapper mapper;

        public ProviderController(IProviderRepository providerRepository, IMapper mapper)
        {
            this.providerRepository = providerRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var providerDomainModel = await providerRepository.GetAll();

                return Ok(mapper.Map<List<ProviderResponseDto>>(providerDomainModel));
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
                var providerDomainModel = await providerRepository.GetByid(id);

                if(providerDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<ProviderResponseDto>(providerDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] AddProviderRequestDomainModel addProviderRequestDomainModel)
        {
            try
            {
                var providerDomainModel = mapper.Map<TblProvider>(addProviderRequestDomainModel);
                await providerRepository.Create(providerDomainModel);

                return Ok(mapper.Map<ProviderResponseDto>(providerDomainModel));
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
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateProviderRequestDomainModel updateProviderRequestDomainModel)
        {
            try
            {
                var providerDomainModel = mapper.Map<TblProvider>(updateProviderRequestDomainModel);
                providerDomainModel = await providerRepository.Update(id, providerDomainModel);

                if(providerDomainModel == null) 
                {
                    return NotFound();
                }

                return Ok(mapper.Map<ProviderResponseDto>(providerDomainModel));
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
                var providerDomainModel = await providerRepository.Delete(id);

                if (providerDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<ProviderResponseDto>(providerDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
