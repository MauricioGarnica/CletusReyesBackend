using AutoMapper;
using CletusReyes.CustomActionFilters;
using CletusReyes.Models.Domain_Model.Product;
using CletusReyes.Models.DTO.Product;
using CletusReyes.Repositories.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var productsDomainModel = await productRepository.GetAll();

                return Ok(mapper.Map<List<ProductResponseDto>>(productsDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            try
            {
                var productDomainModel = await productRepository.GetById(id);

                if(productDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<ProductResponseDto>(productDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] AddProductRequestDomainModel addProductRequestDomainModel, [FromForm] AddProductImageRequestDomainModel addProductImageRequestDomainModel)
        {
            try
            {
                var productDomainModel = new TblProduct
                {
                    Name = addProductRequestDomainModel.Name,
                    Description = addProductRequestDomainModel.Description,
                    Price = addProductRequestDomainModel.Price,
                    MinValue = addProductRequestDomainModel.MinValue,
                    MaxValue = addProductRequestDomainModel.MaxValue,
                    Quantity = addProductRequestDomainModel.Quantity,
                    CategoryId = Guid.Parse(addProductRequestDomainModel.CategoryId),
                    UserIdCreated = addProductRequestDomainModel.UserIdCreated,
                    SizeId = Guid.Parse(addProductRequestDomainModel.SizeId),
                    File = addProductImageRequestDomainModel.File,
                    FileName = addProductImageRequestDomainModel.FileName,
                    FileExtension = Path.GetExtension(addProductImageRequestDomainModel.File.FileName),
                    FileDescription = addProductImageRequestDomainModel.FileDescription
                };

                ValidateFileUpload(productDomainModel);

                if (ModelState.IsValid)
                {
                    await productRepository.Create(productDomainModel);

                    return Ok(mapper.Map<ProductResponseDto>(productDomainModel));
                }
                else
                {
                    return BadRequest(ModelState);
                }
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
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromForm] UpdateProductRequestDomainModel updateProductRequestDomainModel, [FromForm] UpdateProductImageRequestDomainModel updateProductImageRequestDomainModel)
        {
            try
            {
                var productDomainModel = new TblProduct
                {
                    Name = updateProductRequestDomainModel.Name,
                    Description = updateProductRequestDomainModel.Description,
                    Price = updateProductRequestDomainModel.Price,
                    MinValue = updateProductRequestDomainModel.MinValue,
                    MaxValue = updateProductRequestDomainModel.MaxValue,
                    Quantity = updateProductRequestDomainModel.Quantity,
                    File = updateProductImageRequestDomainModel.File,
                    FileName = updateProductImageRequestDomainModel.FileName,
                    FileDescription = updateProductImageRequestDomainModel.FileDescription
                };

                ValidateFileUpload(productDomainModel);

                if (ModelState.IsValid)
                {
                    productDomainModel = await productRepository.Update(id, productDomainModel);

                    if(productDomainModel == null)
                    {
                        return NotFound();
                    }

                    return Ok(mapper.Map<ProductResponseDto>(productDomainModel));
                }
                else
                {
                    return BadRequest(ModelState);
                }
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
                var productDomainModel = await productRepository.Delete(id);

                if(productDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<ProductResponseDto>(productDomainModel));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private void ValidateFileUpload(TblProduct tblProduct)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };

            if (!allowedExtensions.Contains(Path.GetExtension(tblProduct.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            if(tblProduct.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more trhan 10MB, please upload a smaller size file");
            }
        }
    }
}
