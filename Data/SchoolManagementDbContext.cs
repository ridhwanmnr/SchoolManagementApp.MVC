using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolManagementApp.MVC.Data
{
    public partial class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext()
        {
        }

        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Lecturer> Lecturers { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.Code, "UQ__Courses__A25C5AA705B2FB87")
                    .IsUnique();

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
