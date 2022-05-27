using Microsoft.EntityFrameworkCore;
using artifact_manager2.Database.Models;
using artifact_manager2.Database.Models;
using Attribute = artifact_manager2.Database.Models.Attribute;
using System.Linq;
using artifact_manager2.Database.EnhancedModels;

namespace artifact_manager2.Database.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryAttribute> CategoryAttributes { get; set; }
        public DbSet<FloatValue> FloatValuess { get; set; }
        public DbSet<IntegerValue> IntegerValues { get; set; }
        public DbSet<Representative> Representatives { get; set; }
        public DbSet<StringValue> StringValues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"Server=Localhost;database=RpcGameDB;Integrated Security = true");
                //optionsBuilder.UseSqlServer(@"Server=Localhost;database=RpcGameDB;Integrated Security = true");
                optionsBuilder.UseSqlServer(@"Server=Localhost;database=MaciejKrajewskiDB4;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StringValue>()
               .HasKey(nameof(StringValue.RepresentativeId), nameof(StringValue.AttributeId));

            modelBuilder.Entity<IntegerValue>()
               .HasKey(nameof(IntegerValue.RepresentativeId), nameof(IntegerValue.AttributeId));

            modelBuilder.Entity<FloatValue>()
               .HasKey(nameof(FloatValue.RepresentativeId), nameof(FloatValue.AttributeId));

            modelBuilder.Entity<CategoryAttribute>()
                .HasKey(nameof(CategoryAttribute.CategoryId), nameof(CategoryAttribute.AttributeId));

            modelBuilder.Entity<UserRole>()
                .HasKey(nameof(UserRole.UserId), nameof(UserRole.RoleId));

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.userRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(u => u.userRoles)
                .HasForeignKey(u => u.RoleId);
        }

    }
}