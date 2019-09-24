using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ef05.Models
{
    public partial class shopdataContext : DbContext
    {
        public shopdataContext()
        {
        }

        public shopdataContext(DbContextOptions<shopdataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=shopdata;User ID=SA;Password=Password123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CategorySecondId);

                entity.HasIndex(e => e.Name)
                    .HasName("index_name_product")
                    .IsUnique();

                entity.HasIndex(e => e.UserPostId);

                entity.HasOne(d => d.UserPost)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UserPostId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Products_user_post");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
