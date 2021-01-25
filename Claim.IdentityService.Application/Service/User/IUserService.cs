using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Claim.IdentityService.Application.Service.User
{
    public interface IUserService
    {
        Task<Model.AppUser> GetUser(int userId);

        Task<List<Model.AppUser>> GetUsers();

        Task<List<Model.AppUser>> CreateUser(Model.AppUser claim);

        Task UpdateUser(Model.AppUser claim);

        Task DeleteUser(int id);
    }
}
