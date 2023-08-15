using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Sale_Order;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Sale_Order
{
    public class SQLSaleOrderRepository : ISaleOrderRepository
    {
        private readonly CletusReyesDbContext dbContext;

        public SQLSaleOrderRepository(CletusReyesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblSaleOrderHeader>> GetAll()
        {
            return await dbContext.SaleOrderHeaders
                                    .Include(header => header.User)
                                    .Include(header => header.SaleOrderStatus)
                                    .Include(header => header.Details)
                                        .ThenInclude(detail => detail.Product)
                                    .Where(header => header.Status)
                                    .ToListAsync();
        }

        public async Task<List<TblSaleOrderHeader>> GetAllByUser(string id)
        {
            return await dbContext.SaleOrderHeaders
                                    .Include(header => header.SaleOrderStatus)
                                    .Include(header => header.Details)
                                        .ThenInclude(detail => detail.Product)
                                    .Where(header => header.Status)
                                    .Where(header => header.UserId == id)
                                    .ToListAsync();
        }

        public async Task<TblSaleOrderHeader?> GetById(Guid id)
        {
            return await dbContext.SaleOrderHeaders
                                    .Include(header => header.User)
                                    .Include(header => header.SaleOrderStatus)
                                    .Include(header => header.Details)
                                        .ThenInclude(detail => detail.Product)
                                    .FirstOrDefaultAsync(header => header.Id == id);
        }

        public async Task<TblSaleOrderHeader> Create(TblSaleOrderHeader tblSaleOrderHeader, List<TblSaleOrderDetail> tblSaleOrderDetails)
        {
            tblSaleOrderHeader.SaleOrderStatusId = Guid.Parse("34E82473-B511-4B31-A94E-304130EE2EDE");
            tblSaleOrderHeader.Status = true;
            tblSaleOrderHeader.Created_at = DateTime.Now.ToString("G");
            tblSaleOrderHeader.Details = null;
            await dbContext.SaleOrderHeaders.AddAsync(tblSaleOrderHeader);

            tblSaleOrderDetails.ForEach(detail => detail.SaleOrderHeaderId = tblSaleOrderHeader.Id);
            await dbContext.SaleOrderDetails.AddRangeAsync(tblSaleOrderDetails);
            await dbContext.SaveChangesAsync();

            return tblSaleOrderHeader;
        }

        public async Task<List<string>> Update(Guid id, Guid newStatus)
        {
            var saleOrderUpdated = await dbContext.SaleOrderHeaders
                                                    .Include(header => header.Details)
                                                        .ThenInclude(detail => detail.Product)
                                                    .FirstOrDefaultAsync (header => header.Id == id);
            if(saleOrderUpdated == null)
            {
                return new List<string>
                {
                    "0", $"Sale Order with Id: {id} not found"
                };
            }
            else
            {
                if (!newStatus.Equals(Guid.Parse("d5f1c029-61cf-4273-a3d7-431c110e4f15")))
                {
                    saleOrderUpdated.SaleOrderStatusId = newStatus;
                    saleOrderUpdated.Updated_at = DateTime.Now.ToString("G");
                    await dbContext.SaveChangesAsync();
                    return new List<string>
                    {
                        "1", $"Purchase order with Id: {id} was updated"
                    };
                }
                else
                {
                    var productsShortage = saleOrderUpdated.Details
                                                .Where(detail => detail.Product.Quantity - detail.Quantity < detail.Product.MinValue)
                                                .Select(detail => detail.Product.Name);
                    if (productsShortage.Any())
                    {
                        string productsList = string.Join(", ", productsShortage);
                        return new List<string>
                        {
                            "0", $"This sale order cannot be made, because the following products are less than minimum value required in stock: {productsShortage}"
                        };
                    }
                    else
                    {
                        foreach(var detail in saleOrderUpdated.Details)
                        {
                            detail.Product.Quantity -= detail.Quantity;
                        }
                        await dbContext.SaveChangesAsync();

                        return new List<string>
                        {
                            "1", "1", $"Sale order has been updated with Id:{id}, and product quantities have been stored"
                        };
                    }
                }
            }
        }

        public async Task<TblSaleOrderHeader?> Delete(Guid id)
        {
            var saleOrderDeleted = await dbContext.SaleOrderHeaders.FirstOrDefaultAsync(header => header.Id == id);

            if(saleOrderDeleted == null)
            {
                return null;
            }

            saleOrderDeleted.Status = false;
            saleOrderDeleted.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return saleOrderDeleted;
        }
    }
}
