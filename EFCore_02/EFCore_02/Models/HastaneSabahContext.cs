using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCore_02.Models
{
    public partial class HastaneSabahContext : DbContext
    {
        public HastaneSabahContext()
        {
        }

        public HastaneSabahContext(DbContextOptions<HastaneSabahContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bolumler> Bolumlers { get; set; }
        public virtual DbSet<Doktorlar> Doktorlars { get; set; }
        public virtual DbSet<Hastalar> Hastalars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=desktop-8m7d7ge\\sqlexpress;Database=HastaneSabah;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Bolumler>(entity =>
            {
                entity.ToTable("Bolumler");

                entity.HasIndex(e => e.BolumAd, "UQ__Bolumler__7BD2881B7EF6D0FC")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BolumAd)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doktorlar>(entity =>
            {
                entity.ToTable("Doktorlar");

                entity.HasIndex(e => e.SicilNo, "UQ__Doktorla__B736D3C2A3738E1A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdSoyad)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SicilNo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bolum)
                    .WithMany(p => p.Doktorlars)
                    .HasForeignKey(d => d.BolumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doktorlar__Bolum__3D5E1FD2");
            });

            modelBuilder.Entity<Hastalar>(entity =>
            {
                entity.ToTable("Hastalar");

                entity.HasIndex(e => e.TcNo, "UQ__Hastalar__8EF935A62D834643")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TcNo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
