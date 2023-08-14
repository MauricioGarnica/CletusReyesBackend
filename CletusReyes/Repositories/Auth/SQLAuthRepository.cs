﻿using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Auth;
using CletusReyes.Models.Domain_Model.Person;
using CletusReyes.Models.DTO.User;
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

        public async Task<TblPerson?> GetById(string id)
        {
            return await dbContext.Persons.FirstOrDefaultAsync(person => person.User.Id == id);
        }

        public async Task<TblPerson?> Update(string id, UpdateUserRequestDomainModel updateUserRequestDomainModel)
        {
            var userUpdated = await userManager.FindByIdAsync(id);

            if (userUpdated == null)
            {
                return null;
            }

            var tokenEmail = await userManager.GenerateChangeEmailTokenAsync(userUpdated, updateUserRequestDomainModel.Email);
            var resultEmail = await userManager.ChangeEmailAsync(userUpdated, updateUserRequestDomainModel.Email, tokenEmail);

            if (resultEmail.Succeeded)
            {
                await userManager.UpdateNormalizedEmailAsync(userUpdated);
                userUpdated.UserName = updateUserRequestDomainModel.UserName;
                await userManager.UpdateNormalizedUserNameAsync(userUpdated);
                await dbContext.SaveChangesAsync();

                var tokenPhoneNumber = await userManager.GenerateChangePhoneNumberTokenAsync(userUpdated, updateUserRequestDomainModel.PhoneNumber);
                var resultPhoneNumber = await userManager.ChangePhoneNumberAsync(userUpdated, updateUserRequestDomainModel.PhoneNumber, tokenPhoneNumber);

                if (resultPhoneNumber.Succeeded)
                {
                    var tokenPassword = await userManager.GeneratePasswordResetTokenAsync(userUpdated);
                    var resultPassword = await userManager.ResetPasswordAsync(userUpdated, tokenPassword, updateUserRequestDomainModel.Password);

                    if (resultPassword.Succeeded)
                    {
                        var personUpdated = await dbContext.Persons.FirstOrDefaultAsync(person => person.User.Id == id);

                        if (personUpdated == null)
                        {
                            var persosAdded = new TblPerson
                            {
                                Address = updateUserRequestDomainModel.Address,
                                LastName = updateUserRequestDomainModel.LastName,
                                Name = updateUserRequestDomainModel.Name,
                                PostalCode = updateUserRequestDomainModel.PostalCode,
                                Birthday = updateUserRequestDomainModel.Birthday,
                                UserId = id
                            };

                            await dbContext.Persons.AddAsync(persosAdded);
                            await dbContext.SaveChangesAsync();

                            return persosAdded;
                        }

                        personUpdated.Name = updateUserRequestDomainModel.Name;
                        personUpdated.LastName = updateUserRequestDomainModel.LastName;
                        personUpdated.Address = updateUserRequestDomainModel.Address;
                        personUpdated.PostalCode = updateUserRequestDomainModel.PostalCode;
                        personUpdated.Birthday = updateUserRequestDomainModel.Birthday;
                        await dbContext.SaveChangesAsync();

                        return personUpdated;
                    }
                }
            }

            return null;
        }

        public async Task<bool> AddUserToRoles(string userId, List<string> roles)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            foreach (var role in roles)
            {
                var roleExists = await roleManager.FindByNameAsync(role);

                if (roleExists != null)
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