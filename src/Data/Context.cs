using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace database
{
    

    public class Context : IdentityDbContext<UserModel>
    {
        public DbSet<MessageModel> Messages { get; set; }
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