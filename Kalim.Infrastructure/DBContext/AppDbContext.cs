using Kalim.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kalim.Infrastructure.DBContext
{
    public class AppDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<PasswordResetToken> PasswordResetTokens { set; get; }
        public DbSet<ActivationCode> ActivationCodes { set; get; }
        public DbSet<Notification> Notifications { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<RoomMember> RoomMembers { set; get; }
        public DbSet<Lecture> Lectures { set; get; }
        public DbSet<Transcript> Transcripts { set; get; }
        public DbSet<Question> Questions { set; get; }
        public DbSet<Answer> Answers { set; get; }
        public DbSet<Announcement> Announcements { set; get; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoomMember>()
            .HasKey(rm => new { rm.RoomId, rm.StudentId });

            foreach (var relationship in modelBuilder.Model
            .GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }
}
