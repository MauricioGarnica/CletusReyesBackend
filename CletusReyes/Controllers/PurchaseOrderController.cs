using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Purchase_Order;
using CletusReyes.Models.DTO.Purchase_Order;
using CletusReyes.Repositories.Purchase_Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderRepository purchaseOrderRepository;
        private readonly IMapper mapper;

        public PurchaseOrderController(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper)
        {
            this.purchaseOrderRepository = purchaseOrderRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var purchaseOrdersDomainModel = await purchaseOrderRepository.GetAll();

                return Ok(mapper.Map<PurchaseOrderHeaderResponseDto>(purchaseOrdersDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var purchaseOrderDomainModel = await purchaseOrderRepository.GetById(id);

                if(purchaseOrderRepository == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<PurchaseOrderResponseDto>(purchaseOrderDomainModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddPurchaseOrderHeaderRequestDomainModel addPurchaseOrderHeaderRequestDomainModel)
        {
            try
            {
                var purchaseOrderHeaderDomainModel = mapper.Map<TblPurchaseOrderHeader>(addPurchaseOrderHeaderRequestDomainModel);
                var purchaseOrderDetailsDomainModel = mapper.Map<List<TblPurchaseOrderDetail>>(addPurchaseOrderHeaderRequestDomainModel.Details);
                purchaseOrderHeaderDomainModel = await purchaseOrderRepository.Create(purchaseOrderHeaderDomainModel, purchaseOrderDetailsDomainModel);

                return Ok(mapper.Map<PurchaseOrderHeaderResponseDto>(purchaseOrderHeaderDomainModel));
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
                var purchaseOrderUpdated = await purchaseOrderRepository.Update(id, newStatus);

                if(purchaseOrderUpdated == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<PurchaseOrderHeaderResponseDto>(purchaseOrderUpdated));
            }
            catch (Exception ex)
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
                var purchaseOrderDeleted = await purchaseOrderRepository.Delete(id);

                return purchaseOrderDeleted == null ? NotFound() : Ok(mapper.Map<PurchaseOrderHeaderResponseDto>(purchaseOrderDeleted));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
