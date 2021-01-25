using Claim.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Claim.ClaimService.Domain.Commands
{
    public abstract class ClaimCommand : Command
    {
        public string ClaimId { get; protected set; }
        public DateTime DateOfAccident { get; protected set; }
        public string ClaimOwner { get; protected set; }
    }
}
