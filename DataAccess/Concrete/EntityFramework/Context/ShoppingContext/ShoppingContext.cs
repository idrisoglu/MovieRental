using Core.Entities;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MovieRental;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Movie>().ToTable(nameof(Movie), "Movie").Property(p => p.UnitPrice).HasColumnType("nvarchar(50)");
            //modelBuilder.Entity<Category>().ToTable(nameof(Category), "Category");
            //modelBuilder.Entity<OperationClaim>().ToTable(nameof(OperationClaim), "User");
            //modelBuilder.Entity<User>().ToTable(nameof(User), "User");
            //modelBuilder.Entity<CreditCard>().ToTable(nameof(CreditCard), "User");
            //modelBuilder.Entity<UserOperationClaim>().ToTable(nameof(UserOperationClaim), "User");
        }
    }
}
