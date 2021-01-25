using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Claim.ClaimService.Application.Service
{
    public interface IClaimService
    {
        Task<Model.UserClaim> GetClaimByUser(int userId);

        Task<List<Model.UserClaim>> GetClaims();

        Task CreateClaims(Model.UserClaim claim);

        Task UpdateClaims(Model.UserClaim claim);

        Task DeleteClaims(int id);
    }
}
