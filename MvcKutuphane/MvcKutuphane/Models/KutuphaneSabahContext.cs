﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MvcKutuphane.Models
{
    public partial class KutuphaneSabahContext : DbContext
    {
        public KutuphaneSabahContext()
        {
        }

        public KutuphaneSabahContext(DbContextOptions<KutuphaneSabahContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kitaplar> Kitaplars { get; set; }
        public virtual DbSet<Odunc> Oduncs { get; set; }
        public virtual DbSet<Turler> Turlers { get; set; }
        public virtual DbSet<Uyeler> Uyelers { get; set; }
        public virtual DbSet<Yayinevleri> Yayinevleris { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=desktop-8m7d7ge\\sqlexpress;Database=KutuphaneSabah;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Kitaplar>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__Kitaplar__447D36EBA9D256B0");

                entity.ToTable("Kitaplar");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Ad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TurId).HasColumnName("TurID");

                entity.Property(e => e.YayinEviId).HasColumnName("YayinEviID");

                entity.Property(e => e.YazarId).HasColumnName("YazarID");

                entity.HasOne(d => d.Tur)
                    .WithMany(p => p.Kitaplars)
                    .HasForeignKey(d => d.TurId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Kitaplar__TurID__412EB0B6");

                entity.HasOne(d => d.YayinEvi)
                    .WithMany(p => p.Kitaplars)
                    .HasForeignKey(d => d.YayinEviId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Kitaplar__YayinE__4316F928");

                entity.HasOne(d => d.Yazar)
                    .WithMany(p => p.Kitaplars)
                    .HasForeignKey(d => d.YazarId)
                    .HasConstraintName("FK__Kitaplar__YazarI__4222D4EF");
            });

            modelBuilder.Entity<Odunc>(entity =>
            {
                entity.ToTable("Odunc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KitapIsbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("KitapISBN");

                entity.Property(e => e.TeslimTarihi).HasColumnType("date");

                entity.Property(e => e.UyeId).HasColumnName("UyeID");

                entity.Property(e => e.VerilisTarihi).HasColumnType("date");

                entity.HasOne(d => d.KitapIsbnNavigation)
                    .WithMany(p => p.Oduncs)
                    .HasForeignKey(d => d.KitapIsbn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Odunc__KitapISBN__46E78A0C");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.Oduncs)
                    .HasForeignKey(d => d.UyeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Odunc__UyeID__45F365D3");
            });

            modelBuilder.Entity<Turler>(entity =>
            {
                entity.ToTable("Turler");

                entity.HasIndex(e => e.TurAd, "UQ__Turler__A1D0193DF1DB5827")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TurAd)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uyeler>(entity =>
            {
                entity.ToTable("Uyeler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdSoyad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.Mail)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Meslek)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TcNo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UyelikTarihi).HasColumnType("date");
            });

            modelBuilder.Entity<Yayinevleri>(entity =>
            {
                entity.ToTable("Yayinevleri");

                entity.HasIndex(e => e.Ad, "UQ__Yayinevl__3214AD0079543AC8")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Yazarlar>(entity =>
            {
                entity.ToTable("Yazarlar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdSoyad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.Mail)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TurId).HasColumnName("TurID");

                entity.HasOne(d => d.Tur)
                    .WithMany(p => p.Yazarlars)
                    .HasForeignKey(d => d.TurId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Yazarlar__TurID__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
