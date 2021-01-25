using System;
using System.Collections.Generic;
using System.Text;

namespace Claim.ClaimService.Domain.Commands
{
    public class CreateClaimCommand : ClaimCommand
    {
        public CreateClaimCommand(string claimId, DateTime dateOfAccident, string claimOwner)
        {
            ClaimId = claimId;
            DateOfAccident = dateOfAccident;
            ClaimOwner = claimOwner;
        }
    }
}
