using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace database
{
    public class Context : IdentityDbContext<UserModel, RoleModel, string, IdentityUserClaim<string>,
    UserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<ReportMessageModel> Reports { get; set; }
        public DbSet<AanmeldModel> Aanmelding { get; set; }
        public DbSet<Caregiver> Caregiver { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<ChatRoom> Rooms { get; set; }
        public DbSet<ChatUser> ChatUser { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<ReportMessageModel> Reports{get;set;}
        
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChatRoom>()
            .HasAlternateKey(c => c.RoomName);

            modelBuilder.Entity<AanmeldModel>()
            .HasOne(b => b.User)
            .WithOne()
            .HasForeignKey<AanmeldModel>(b => b.UserId);

            // modelBuilder.Entity<Caregiver>()
            // .HasOne(u => u.User)
            // .WithOne(u => u.Caregiver)
            // .HasForeignKey<Caregiver>(c => c.UserId);

            modelBuilder.Entity<UserModel>()
            .HasOne<Caregiver>(u => u.Caregiver)
            .WithOne()
            .HasForeignKey<Caregiver>(c => c.UserId);

            modelBuilder.Entity<AanmeldModel>()
            .HasOne(c => c.Caregiver)
            .WithOne()
            .HasForeignKey<AanmeldModel>(b => b.CaregiverId);

            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ChatUser>()
                .HasKey(x => new { x.UserId, x.ChatRoomId });

            modelBuilder.Entity<ChatUser>()
                .HasOne<UserModel>(u => u.User)
                .WithMany(cr => cr.ChatRooms)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<ChatUser>()
                .HasOne<ChatRoom>(cr => cr.ChatRoom)
                .WithMany(u => u.Users)
                .HasForeignKey(cr => cr.ChatRoomId);
        }
    }
}