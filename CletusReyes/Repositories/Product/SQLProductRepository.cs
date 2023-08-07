using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Product;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Product
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly CletusReyesDataDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public SQLProductRepository(CletusReyesDataDbContext dbContext, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<TblProduct>> GetAll()
        {
            var products = dbContext.Products.Include("Category").Include("Size").AsQueryable();

            products = products.Where(product => product.Status == true);

            return await products.ToListAsync();
        }

        public async Task<TblProduct?> GetById(Guid id)
        {
            return await dbContext.Products.Include("Category").Include("Size").FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task<TblProduct> Create(TblProduct tblProduct)
        {

            var product = tblProduct;
            product.Created_at = DateTime.Now.ToString("G");
            product.Status = true;
            product = await UploadImage(product);

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            return product;
        }

        public async Task<TblProduct?> Update(Guid id, TblProduct tblProduct)
        {
            var productUpdated = await dbContext.Products.Include("Category").Include("Size").FirstOrDefaultAsync(product => product.Id == id);

            if(productUpdated == null)
            {
                return null;
            }

            productUpdated.Name = tblProduct.Name;
            productUpdated.Description = tblProduct.Description;
            productUpdated.Price = tblProduct.Price;
            productUpdated.MinValue = tblProduct.MinValue;
            productUpdated.MaxValue = tblProduct.MaxValue;
            productUpdated.Quantity = tblProduct.Quantity;
            productUpdated.UserIdUpdated = tblProduct.UserIdUpdated;
            productUpdated.Updated_at = DateTime.Now.ToString("G");
            productUpdated = await UploadImage(productUpdated);
            await dbContext.SaveChangesAsync();

            return productUpdated;
        }

        public async Task<TblProduct?> Delete(Guid id)
        {
            var productUpdated = await dbContext.Products.Include("Category").Include("Size").FirstOrDefaultAsync(product => product.Id == id);

            if (productUpdated == null)
            {
                return null;
            }

            productUpdated.Status = false;
            productUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return productUpdated;
        }

        private async Task<TblProduct> UploadImage(TblProduct tblProduct)
        {
            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{tblProduct.FileName}{tblProduct.FileExtension}");

            //Upload image to local path
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await tblProduct.File.CopyToAsync(stream);

            var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}:://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/Images/{tblProduct.FileName}{tblProduct.FileExtension}";
            tblProduct.FilePath = urlFilePath;

            return tblProduct;
        }
    }
}
