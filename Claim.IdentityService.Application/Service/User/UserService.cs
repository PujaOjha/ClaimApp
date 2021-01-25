using Claim.IdentityService.Application.Model;
using Claim.IdentityService.Application.Service.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Claim.IdentityService.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserService userService;

        public UserService(IUserService userService)
        {
            this.userService = userService;
        }

        public Task<List<AppUser>> CreateUser(AppUser claim)
        {
            return userService.CreateUser(claim);
        }

        public Task DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }

        public Task<AppUser> GetUser(int userId)
        {
            return userService.GetUser(userId);
        }

        public Task<List<AppUser>> GetUsers()
        {
            return userService.GetUsers();
        }

        public Task UpdateUser(AppUser claim)
        {
            return userService.UpdateUser(claim);
        }
    }
}
