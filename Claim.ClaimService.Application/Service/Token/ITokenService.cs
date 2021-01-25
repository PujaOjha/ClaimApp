using Claim.ClaimService.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Application.Service.Token
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
