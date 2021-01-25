using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Claim.ClaimService.Application.Model;
using Claim.ClaimService.Data;
using Claim.ClaimService.Domain.Commands;
using Claim.Domain.Core.Bus;

namespace Claim.ClaimService.Application.Service
{
    public class ClaimService : IClaimService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IEventBus _bus;

        public ClaimService(IUnitOfWork unitOfWork, IEventBus bus)
        {
            this.unitOfWork = unitOfWork;
            _bus = bus;
        }

        public async Task CreateClaims(Model.UserClaim claim)
        {
            var claimObj = claim.MapToClaimDataModel();
            await unitOfWork.ClaimRepository.Create(claimObj);
            await unitOfWork.Complete();
            var createTransferCommand = new CreateClaimCommand(
                  claimObj.ClaimId.ToString(),                   
                    claimObj.DateOfAccident?? DateTime.Now, 
                   claimObj.FirstName
               );

           await _bus.SendCommand(createTransferCommand);
        }

        public async Task DeleteClaims(int id)
        {
            var claimData = await unitOfWork.ClaimRepository.GetById(id);
            unitOfWork.ClaimRepository.Delete(claimData);
            await unitOfWork.Complete();
        }

        public async Task<Model.UserClaim> GetClaimByUser(int userId)
        {
            var claimData =  await unitOfWork.ClaimRepository.GetById(userId);
            await unitOfWork.Complete();
            return claimData.MapToUserClaimModel();
        }

        public async Task<List<Model.UserClaim>> GetClaims()
        {
            var claimData = await unitOfWork.ClaimRepository.GetAll();
            await unitOfWork.Complete();
            var result = new List<UserClaim>();
             claimData.ForEach(x => {
                result.Add(x.MapToUserClaimModel());
                });
            return result;
        }

        public Task UpdateClaims(Model.UserClaim claim)
        {
            throw new NotImplementedException();
        }
    }
}
