using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Auth
{
    public class SQLAuthRepository : IAuthRepository
    {
        private readonly UserManager<TblUser> userManager;
        private readonly RoleManager<TblRoles> roleManager;
        private readonly CletusReyesDbContext dbContext;

        public SQLAuthRepository(UserManager<TblUser> userManager, RoleManager<TblRoles> roleManager, CletusReyesDbContext dbContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.dbContext = dbContext;
        }

        public async Task<bool> AddUserToRoles(string userId, List<string> roles)
        {
            var user = await userManager.FindByIdAsync(userId);

            if(user == null)
            {
                return false;
            }

            foreach (var role in roles)
            {
                var roleExists = await roleManager.FindByNameAsync(role);

                if(roleExists != null)
                {
                    var userRole = new TblUserRoles
                    {
                        UserId = user.Id,
                        RoleId = roleExists.Id
                    };

                    await dbContext.UserRoles.AddAsync(userRole);
                    await dbContext.SaveChangesAsync();
                }
            }

            return true;
        }

        public async Task<List<string?>> GetRoles(string userId)
        {
            return await dbContext.UserRoles.Include(userRole => userRole.Roles).Where(userRole => userRole.UserId == userId).Select(userRole => userRole.Roles.Name).ToListAsync();
        }
    }
}
