using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DSS.Api.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DSS.Api.Data {
    public class DSSDbContext : IdentityDbContext {
        public DSSDbContext(DbContextOptions<DSSDbContext> options)
            : base(options) {
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
                                        CancellationToken cancellationToken = default) {
            foreach (var entity in ChangeTracker.Entries()
                                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified)
                                    .Where(e => e.Entity is ISluggedEntity)
                                    .Select(e => e.Entity as ISluggedEntity)
                                    .Where(e => string.IsNullOrEmpty(e.Slug))) {
                entity.Slug = entity.GenerateSlug(this);
            }
        }
        public DbSet<AudioItem> AudioItems { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
