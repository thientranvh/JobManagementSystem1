using JobManagementSystem.Common;
using JobManagementSystem.Common.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace JobManagementSystem.DataAccess.Models
{
    public class JobSystemDbContext : DbContext
    {
        public JobSystemDbContext(DbContextOptions<JobSystemDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.Id });
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
                entity.Property(e => e.FullName).HasMaxLength(30);
                entity.Property(e => e.PhoneNumber).HasMaxLength(20);
                entity.HasIndex(e => new { e.Email }).IsUnique();
                entity.HasIndex(e => new { e.Role, e.FullName, e.CreateBy });
                entity.HasData(new User
                {
                    Id = 1,
                    Email = UserDefaults.MailAdmin + UserDefaults.DomainJob,
                    Password = Encryptor.Md5Hash(UserDefaults.Password),
                    FullName = UserDefaults.AdminName,
                    BirthDay = DateTime.ParseExact(UserDefaults.BirthDayAdmin, FormatTimes.DdMmYyyy,
                                           CultureInfo.InvariantCulture),
                    Gender = true,
                    PhoneNumber = UserDefaults.PhoneNumberAdmin,
                    Role = (int)RoleEnum.Admin,
                    Address = UserDefaults.AddressDefault,
                    CreateAt = DateTime.Now,
                    Status = true
                });
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.HasIndex(e => new { e.Id, e.Name }).IsUnique();
                entity.HasIndex(e => e.CreateBy);
                entity
                    .HasOne(e => e.User)
                    .WithMany(e => e.Categories)
                    .HasForeignKey(e => e.CreateBy)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Title);
                entity.Property(e => e.Content).HasColumnType(TypeOf.Text);
                entity.Property(e => e.FeedbackContent).HasColumnType(TypeOf.Text);
                entity.HasIndex(e => new { e.Id, e.CreateBy });
                entity
                    .HasOne(e => e.User)
                    .WithMany(e => e.Contacts)
                    .HasForeignKey(e => e.CreateBy)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
