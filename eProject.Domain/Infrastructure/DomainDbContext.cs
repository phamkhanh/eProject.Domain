using System.Data.Entity;
using Infrastructure.Models;
using Infrastructure.zModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Infrastructure
{
    //public class ProjectDbContext : DbContext
    public class DomainDbContext : IdentityDbContext<ApplicationUser>
    {
        public DomainDbContext() : base("eProjectConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false; // khi load bảng cha. bảng con sẽ không tự động load theo
        }

        public static DomainDbContext Create()
        {
            return new DomainDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }

        public DbSet<Error> Errors { set; get; }
    }
}