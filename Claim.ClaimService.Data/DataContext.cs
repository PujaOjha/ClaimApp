using Claim.ClaimService.Data.DataModel;
using Microsoft.EntityFrameworkCore;


namespace Claim.ClaimService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<AppUserRole> AppUserRole { get; set; }
        public DbSet<DataModel.Claim> Claim { get; set; }
    }
}
