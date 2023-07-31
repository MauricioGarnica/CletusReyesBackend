using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using CletusReyes.Models.DTO.Unit_Measure;
using CletusReyes.Repositories.Unit_Measure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitMeasureController : ControllerBase
    {
        private readonly IUnitMeasureRepository unitMeasureRepository;
        private readonly IMapper mapper;
        private readonly CletusReyesDataDbContext dbContext;

        public UnitMeasureController(IUnitMeasureRepository unitMeasureRepository, IMapper mapper, CletusReyesDataDbContext dbContext)
        {
            this.unitMeasureRepository = unitMeasureRepository;
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var unitMeasuresDomainModel = await unitMeasureRepository.GetAll();

                return Ok(mapper.Map<UnitMeasureResponseDto>(unitMeasuresDomainModel));
            }
            catch(Exception ex)
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
                var unitMeasureDomainModel = await unitMeasureRepository.GetById(id);

                if(unitMeasureDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<UnitMeasureResponseDto>(unitMeasureDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] AddUnitMeasureRequestDomainModel addUnitMeasureRequestDomainModel)
        {
            try
            {
                var unitMeasureDomainModel = mapper.Map<TblUnitMeasure>(addUnitMeasureRequestDomainModel);
                await unitMeasureRepository.Create(unitMeasureDomainModel);

                return Ok(mapper.Map<UnitMeasureResponseDto>(unitMeasureDomainModel));
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
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUnitMeasureRequestDomainModel updateUnitMeasureRequestDomainModel)
        {
            try
            {
                var unitMeasureDomainModel = mapper.Map<TblUnitMeasure>(updateUnitMeasureRequestDomainModel);
                unitMeasureDomainModel = await unitMeasureRepository.Update(id, unitMeasureDomainModel);

                if(unitMeasureDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<UnitMeasureResponseDto>(unitMeasureDomainModel));
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
                var unitMeasureDomainModel = await unitMeasureRepository.Delete(id);

                if( unitMeasureDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<UnitMeasureResponseDto>(unitMeasureDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
