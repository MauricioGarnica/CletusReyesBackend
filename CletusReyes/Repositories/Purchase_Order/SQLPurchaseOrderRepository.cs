using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Purchase_Order;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Purchase_Order
{
    public class SQLPurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly CletusReyesDbContext dbContext;

        public SQLPurchaseOrderRepository(CletusReyesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblPurchaseOrderHeader>> GetAll()
        {
            return await dbContext.PurchaseOrderHeaders
                                    .Include(header => header.PurchaseOrderStatus)
                                    .Include(header => header.Provider)
                                    .Where(header => header.Status)
                                    .ToListAsync();
        }

        public async Task<TblPurchaseOrderHeader?> GetById(Guid id)
        {
            return await dbContext.PurchaseOrderHeaders
                                    .Include(header => header.PurchaseOrderStatus)
                                    .Include(header => header.Provider)
                                    .Include(header => header.Details)
                                        .ThenInclude(detail => detail.RawMaterial)
                                    .FirstOrDefaultAsync(header => header.Id == id);
        }

        public async Task<TblPurchaseOrderHeader> Create(TblPurchaseOrderHeader tblPurchaseOrderHeader, List<TblPurchaseOrderDetail> tblPurchaseOrderDetails)
        {
            tblPurchaseOrderHeader.Status = true;
            tblPurchaseOrderHeader.Created_at = DateTime.Now.ToString("G");
            await dbContext.PurchaseOrderHeaders.AddAsync(tblPurchaseOrderHeader);
            await dbContext.SaveChangesAsync();

            tblPurchaseOrderDetails.ForEach(detail => detail.PurchaseOrderHeaderId = tblPurchaseOrderHeader.Id);
            await dbContext.PurchaseOrderDetails.AddRangeAsync(tblPurchaseOrderDetails);
            await dbContext.SaveChangesAsync();

            return tblPurchaseOrderHeader;
        }

        public async Task<List<string>?> Update(Guid id, Guid newStatus)
        {
            var purchaseOrderUpdated = await dbContext.PurchaseOrderHeaders
                                                        .Include(header => header.Details)
                                                            .ThenInclude(detail => detail.RawMaterial)
                                                        .FirstOrDefaultAsync(header => header.Id == id);

            if(purchaseOrderUpdated == null)
            {
                return new List<string>
                {
                    "0", $"Purchase Order with Id: {id} not found"
                };
            }

            if (!newStatus.Equals(Guid.Parse("5E257C72-E959-4D0D-9894-1C8682515A3A")))
            {
                purchaseOrderUpdated.PurchaseOrderStatusId = newStatus;
                purchaseOrderUpdated.Updated_at = DateTime.Now.ToString("G");
                await dbContext.SaveChangesAsync();

                return new List<string>
                {
                    "1", $"Purchase order with Id: {id} was updated"
                };
            }
            else
            {
                var rawMaterialsShortage = purchaseOrderUpdated.Details
                                            .Where(detail => detail.RawMaterial.Quantity + detail.Quantity > detail.RawMaterial.MaxValue)
                                            .Select(detail => detail.RawMaterial.Name);
                if(rawMaterialsShortage.Any())
                {
                    string rawMaterialsList = string.Join(", ", rawMaterialsShortage);
                    return new List<string>
                    {
                        "0", $"This purchase order cannot be made, because the following raw materials are more than maximum value required in stock: {rawMaterialsList}"
                    };
                }
                else
                {
                    foreach(var detail in purchaseOrderUpdated.Details)
                    {
                        detail.RawMaterial.Quantity += detail.Quantity;
                    }
                    await dbContext.SaveChangesAsync();

                    return new List<string>
                    {
                        "1", $"Purchase order has been updated with Id:{id}, and raw material quantities have been stored"
                    };
                }
            }
        }

        public async Task<TblPurchaseOrderHeader?> Delete(Guid id)
        {
            var purchaseOrderDeleted = await dbContext.PurchaseOrderHeaders.FirstOrDefaultAsync(header => header.Id == id);

            if (purchaseOrderDeleted == null)
            {
                return null;
            }

            purchaseOrderDeleted.Status = false;
            purchaseOrderDeleted.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return purchaseOrderDeleted;
        }
    }
}
