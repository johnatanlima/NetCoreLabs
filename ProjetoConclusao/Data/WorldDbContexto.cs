using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoConclusao.Models
{
    public partial class WorldDbContexto : DbContext
    {
        public WorldDbContexto(DbContextOptions<WorldDbContexto> options)
            : base(options)
        {
            
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("CountryCode");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnType("char(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("char(35)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Population)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_ibfk_1");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("country");

                entity.Property(e => e.Code)
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NationalFlag).HasColumnType("varchar(45)");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");
            });
        }
    }
}
