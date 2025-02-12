using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorEFIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // SQLite st�der inte nvarchar(max), konvertera till TEXT
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in builder.Model.GetEntityTypes())
                {
                    foreach (var property in entityType.GetProperties())
                    {
                        if (property.GetColumnType() == "nvarchar(max)")
                        {
                            property.SetColumnType("TEXT");
                        }
                    }
                }
            }
        }
    }
}
