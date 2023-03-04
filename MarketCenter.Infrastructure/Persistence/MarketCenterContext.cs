

using MarketCenter.Domain.Common;
using MarketCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketCenter.Infrastructure.Persistence
{
    public class MarketCenterContext : DbContext
    {
        public MarketCenterContext(DbContextOptions<MarketCenterContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "Test";
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "Test";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
