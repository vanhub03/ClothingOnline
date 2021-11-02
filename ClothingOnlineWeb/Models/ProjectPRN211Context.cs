using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.IO;
#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class ProjectPRN211Context : DbContext
    {
        public ProjectPRN211Context()
        {
        }

        public ProjectPRN211Context(DbContextOptions<ProjectPRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Productorder> Productorders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyProjectDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK_Account");

                entity.ToTable("account");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Isadmin).HasColumnName("isadmin");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("categoryname");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("image");

                entity.Property(e => e.Imageid)
                    .ValueGeneratedNever()
                    .HasColumnName("imageid");

                entity.Property(e => e.Imagelink)
                    .IsRequired()
                    .HasColumnName("imagelink");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.Productid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_image_Product");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customername");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Productorderid).HasColumnName("productorderid");

                entity.Property(e => e.Totalprice)
                    .IsRequired()
                    .HasColumnName("totalprice");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Accountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_Account");

                entity.HasOne(d => d.Productorder)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Productorderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_productorder");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("price");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("productname");

                entity.Property(e => e.Unitinstock).HasColumnName("unitinstock");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_category");
            });

            modelBuilder.Entity<Productorder>(entity =>
            {
                entity.ToTable("productorder");

                entity.Property(e => e.Productorderid).HasColumnName("productorderid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Productorders)
                    .HasForeignKey(d => d.Productid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_productorder_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
