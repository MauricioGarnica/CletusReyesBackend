using CletusReyes.Models.DTO.Analytical;
using CletusReyes.Repositories.Analytical;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticalController : ControllerBase
    {
        private readonly IAnalyticalRepository analyticalRepository;

        public AnalyticalController(IAnalyticalRepository analyticalRepository)
        {
            this.analyticalRepository = analyticalRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetCharts([FromQuery]int? mes)
        {
            try
            {
                var charts = new AnalyticalResponseDto
                {
                    GetClientesVentas = await analyticalRepository.GetClientesVentas(mes),
                    GetMateriaComprada = await analyticalRepository.GetMateriaComprada(mes),
                    GetProductosVendidos = await analyticalRepository.GetProductosVendidos(mes),
                    GetProveedoresCompras = await analyticalRepository.GetProveedoresCompras(mes),
                    GetTotalCompras = await analyticalRepository.GetTotalCompras(mes),
                    GetTotalGastos = await analyticalRepository.GetTotalGastos(mes),
                    GetTotalIngresos = await analyticalRepository.GetTotalIngresos(mes),
                    GetTotalVentas = await analyticalRepository.GetTotalVentas(mes),
                };
                return Ok(charts);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
