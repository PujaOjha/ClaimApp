using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Claim.ClaimService.Data.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Claim.ClaimService.Data.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private DataContext _ctx;

        public UserRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CreateUser(AppUser user)
        {
           await _ctx.Users.AddAsync(user);
           await _ctx.SaveChangesAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
           var user = await _ctx.Users.FindAsync(id);
            return user;
        }

        public async  Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _ctx.Users.ToListAsync();            
        }

        public async Task Update(AppUser user)
        {
            var userData = await _ctx.Users.FindAsync(user.Id);
            userData.Gender = user.Gender;
            userData.City = user.City;
            userData.Country = user.Country;
            await _ctx.SaveChangesAsync();
        }

    }
}
