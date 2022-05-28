using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Educasis.Models
{
    public partial class educasisContext : DbContext
    {
        public educasisContext()
        {
        }

        public educasisContext(DbContextOptions<educasisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Ip> Ips { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vote> Votes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contacts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .HasComputedColumnSql("('V-'+right('0000'+CONVERT([varchar],[id]),(4)))", false);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Ip>(entity =>
            {
                entity.ToTable("ip");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .HasComputedColumnSql("('V-'+right('0000'+CONVERT([varchar],[id]),(4)))", false);

                entity.Property(e => e.Ip1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .HasComputedColumnSql("('V-'+right('0000'+CONVERT([varchar],[id]),(4)))", false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Users)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("users");
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.ToTable("votes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appreciation).HasColumnName("appreciation");

                entity.Property(e => e.Cod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .HasComputedColumnSql("('V-'+right('0000'+CONVERT([varchar],[id]),(4)))", false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
