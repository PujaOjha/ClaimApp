using Microsoft.AspNetCore.Identity;

namespace Claim.IdentityService.Application.Model
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}