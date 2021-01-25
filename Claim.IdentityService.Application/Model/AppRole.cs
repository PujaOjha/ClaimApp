using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Claim.IdentityService.Application.Model
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}