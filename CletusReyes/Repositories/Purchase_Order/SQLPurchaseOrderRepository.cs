using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Purchase_Order;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Purchase_Order
{
    public class SQLPurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLPurchaseOrderRepository(CletusReyesDataDbContext dbContext)
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

        public async Task<TblPurchaseOrderHeader?> Update(Guid id, Guid newStatus)
        {
            var purchaseOrderUpdated = await dbContext.PurchaseOrderHeaders.FirstOrDefaultAsync(header => header.Id == id);

            if(purchaseOrderUpdated == null)
            {
                return null;
            }

            purchaseOrderUpdated.PurchaseOrderStatusId = newStatus;
            purchaseOrderUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();
            
            return purchaseOrderUpdated;
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
