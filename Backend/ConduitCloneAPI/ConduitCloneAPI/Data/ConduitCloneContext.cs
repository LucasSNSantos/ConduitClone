using ConduitCloneAPI.Entities;
using Microsoft;
using Microsoft.EntityFrameworkCore;

namespace ConduitCloneAPI.Data
{
    public class ConduitCloneContext: DbContext
    {
        public ConduitCloneContext(DbContextOptions<ConduitCloneContext> options):base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<Tag>().ToTable("Tag");
        }

    }
}
