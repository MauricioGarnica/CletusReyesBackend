using AutoMapper;
using CletusReyes.Data;
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
        private readonly CletusReyesDataDbContext dbContext;
        private readonly ISizeRepository sizeRepository;
        private readonly IMapper mapper;

        public SizeController(CletusReyesDataDbContext dbContext, ISizeRepository sizeRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
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
    }
}
