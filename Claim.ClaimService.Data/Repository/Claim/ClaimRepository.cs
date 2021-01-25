using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Data.Repository.Claim
{
    public interface ClaimRepository
    {
        Task Update(DataModel.Claim claim);
        Task CreateUser(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
    }
}
