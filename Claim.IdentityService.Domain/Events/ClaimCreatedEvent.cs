using Claim.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Claim.ClaimService.Domain.Events
{
    public class ClaimCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public ClaimCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
