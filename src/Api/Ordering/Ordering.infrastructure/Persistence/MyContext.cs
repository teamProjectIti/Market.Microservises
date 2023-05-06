using Microsoft.EntityFrameworkCore;
using Ordering.Doman.Common.Entities;
using Ordering.Doman.Common.EntityBase;
using System.Collections.Generic;

namespace Ordering.infrastructure.Persistence
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }


        public DbSet<Orders> Orders { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "swn";
                        entry.Entity.IsDeleted = false;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "swn";
                        entry.Entity.IsDeleted = false;
                        break;

                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.Entity.IsDeleted = true;
                        break;

                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
