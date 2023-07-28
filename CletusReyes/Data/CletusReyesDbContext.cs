using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Data
{
    public class CletusReyesDbContext : IdentityDbContext
    {
        public CletusReyesDbContext(DbContextOptions<CletusReyesDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRoleId = "31f16eb0-8649-4015-9edd-b179b461a2dd";
            var customerRoleId = "f71926a4-5573-4a11-bb9c-875d856cd446";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new IdentityRole
                {
                    Id = customerRoleId,
                    ConcurrencyStamp = customerRoleId,
                    Name = "Customer",
                    NormalizedName = "Customer".ToUpper()
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
