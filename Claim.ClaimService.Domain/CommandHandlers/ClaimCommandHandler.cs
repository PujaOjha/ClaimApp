using MediatR;
using Claim.ClaimService.Domain.Commands;
using Claim.ClaimService.Domain.Events;
using Claim.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text; 
using System.Threading;
using System.Threading.Tasks;

namespace Claim.ClaimService.Domain.CommandHandlers
{
    public class ClaimCommandHandler : IRequestHandler<CreateClaimCommand, bool>
    {
        private readonly IEventBus _bus;

        public ClaimCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateClaimCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new ClaimCreatedEvent(request.ClaimId, request.DateOfAccident, request.ClaimOwner));

            return Task.FromResult(true);
        }
    }
}
