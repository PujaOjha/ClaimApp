using Claim.ClaimService.Data.DataModel;
using Claim.ClaimService.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Data
{
        public interface IUnitOfWork
        {
            IDataRepository<AppUser> UserRepository { get; }
            IDataRepository<DataModel.Claim> ClaimRepository { get; }
            
            Task<bool> Complete();
            bool HasChanges();
        }
    
}
