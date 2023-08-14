using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Sale_Order;
using CletusReyes.Models.DTO.Sale_Order;
using CletusReyes.Repositories.Sale_Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleOrderController : ControllerBase
    {
        private readonly ISaleOrderRepository saleOrderRepository;
        private readonly IMapper mapper;

        public SaleOrderController(ISaleOrderRepository saleOrderRepository, IMapper mapper)
        {
            this.saleOrderRepository = saleOrderRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var saleOrdersDomainModel = await saleOrderRepository.GetAll();

                return Ok(saleOrdersDomainModel);
                //return Ok(mapper.Map<SaleOrderResponseDto>(saleOrdersDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var saleOrderDomainModel = await saleOrderRepository.GetById(id);

                return saleOrderRepository == null ? NotFound() : Ok(mapper.Map<SaleOrderHeaderResponseDto>(saleOrderDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create(AddSaleOrderHeaderRequestDomainModel addSaleOrderHeaderRequestDomainModel)
        {
            try
            {
                var saleOrderHeaderDomainModel = mapper.Map<TblSaleOrderHeader>(addSaleOrderHeaderRequestDomainModel);
                var saleOrderDetailsDomainModel = mapper.Map<List<TblSaleOrderDetail>>(addSaleOrderHeaderRequestDomainModel.Details);
                saleOrderHeaderDomainModel = await saleOrderRepository.Create(saleOrderHeaderDomainModel, saleOrderDetailsDomainModel);

                return Ok(mapper.Map<SaleOrderHeaderResponseDto>(saleOrderHeaderDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:Guid}/{newStatus:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, Guid newStatus)
        {
            try
            {
                var saleOrderUpdate = await saleOrderRepository.Update(id, newStatus);

                return saleOrderUpdate == null ? NotFound() : saleOrderUpdate[0] == "0" ? BadRequest(saleOrderUpdate[1]) : Ok(saleOrderUpdate[1]);
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
                var saleOrderDeleted = await saleOrderRepository.Delete(id);

                return saleOrderDeleted == null ? NotFound() : Ok(mapper.Map<SaleOrderHeaderResponseDto>(saleOrderDeleted));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
