using InStaging.Domain;
using InStaging.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace InStaging.SqlDataService
{
    public class SqlDataContext : DbContext
    {
        public SqlDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<AppLink> AppLinks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentFile> CommentFiles { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserApplication> UserApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //primary keys
            modelBuilder.Entity<Application>().HasKey(s => s.Id);
            modelBuilder.Entity<AppLink>().HasKey(s => s.Id);
            modelBuilder.Entity<Comment>().HasKey(s => s.Id);
            modelBuilder.Entity<CommentFile>().HasKey(s => s.Id);
            modelBuilder.Entity<File>().HasKey(s => s.Id);
            modelBuilder.Entity<Ticket>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().HasKey(s => s.Id);
            //composite keys
            modelBuilder.Entity<UserApplication>().HasKey(s => new { s.ApplicationId, s.UserId });

            //user application m-m
            modelBuilder.Entity<User>().HasMany(s => s.UserApplications).WithOne(s => s.User).HasForeignKey(s => s.UserId);
            modelBuilder.Entity<Application>().HasMany(s => s.UserApplications).WithOne(s => s.Application).HasForeignKey(s => s.ApplicationId);

            //user comments
            modelBuilder.Entity<User>().HasMany(s => s.Comments).WithOne(s => s.User).HasForeignKey(s => s.UserId);
            modelBuilder.Entity<User>().HasMany(s => s.AssignedTickets).WithOne(s => s.AssignedUser).HasForeignKey(s => s.AssignedUserId);

            //comment files
            modelBuilder.Entity<Comment>().HasMany(s => s.CommentFiles).WithOne(s => s.Comment).HasForeignKey(s => s.CommentId);
            modelBuilder.Entity<CommentFile>().HasOne(s => s.File).WithMany().HasForeignKey(s => s.FileId);

            //ticket
            modelBuilder.Entity<Ticket>().HasMany(s => s.Comments).WithOne(s => s.Ticket).HasForeignKey(s => s.TicketId);

        }

    }
}
