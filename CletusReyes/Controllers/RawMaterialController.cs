using AutoMapper;
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
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
