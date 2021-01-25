using Claim.ClaimService.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Claim.IdentityService.Application.Service.User
{
    public interface IUserService
    {
        Task<AppUser> GetUser(int userId);

        Task<List<AppUser>> GetUsers();

        Task CreateUser(AppUser claim);

        Task UpdateUser(AppUser claim);

        Task DeleteUser(int id);
    }
}
