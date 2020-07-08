using InStaging.Domain.DataObjects;
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
            modelBuilder.Entity<Application>().HasKey(s => s.Id);
            modelBuilder.Entity<AppLink>().HasKey(s => s.Id);
            modelBuilder.Entity<Comment>().HasKey(s => s.Id);
            modelBuilder.Entity<CommentFile>().HasKey(s => s.Id);
            modelBuilder.Entity<File>().HasKey(s => s.Id);
            modelBuilder.Entity<Ticket>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().HasKey(s => s.Id);
            modelBuilder.Entity<UserApplication>().HasKey(s => s.Id);
        }
    }
}
