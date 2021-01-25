using Claim.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Claim.ClaimService.Domain.Events
{
    public class ClaimCreatedEvent : Event
    {
        public string ClaimId { get; protected set; }
        public DateTime DateOfAccident { get; protected set; }
        public string ClaimOwner { get; protected set; }

        public ClaimCreatedEvent(string claimId, DateTime dateOfAccident, string claimOwner)
        {
            ClaimId = claimId;
            DateOfAccident = dateOfAccident;
            ClaimOwner = claimOwner;
        }
    }
}
