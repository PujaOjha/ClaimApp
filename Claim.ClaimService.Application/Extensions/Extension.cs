using Claim.ClaimService.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Application
{
    public static class Extension
    {
        public static Data.DataModel.Claim MapToClaimDataModel(this UserClaim userClaim)
        {
            var claimData = new Data.DataModel.Claim()
            {
                FirstName = userClaim.FirstName,
                LastName = userClaim.LastName,
                DateOfAccident = userClaim.DateOfAccident,
                PatientGender = userClaim.PatientGender,
                TelephoneNumber = userClaim.TelephoneNumber
            };
            return claimData;
        }

        public static UserClaim  MapToUserClaimModel(this Data.DataModel.Claim claimData)
        {
            var userClaim = new UserClaim()
            {
                FirstName = claimData.FirstName,
                LastName = claimData.LastName,
                DateOfAccident = claimData.DateOfAccident,
                PatientGender = claimData.PatientGender,
                TelephoneNumber = claimData.TelephoneNumber
            };
            return userClaim;
        }
    }
}
