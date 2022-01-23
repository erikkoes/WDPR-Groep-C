using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Models;
using Message;
namespace database
{
    public class Context : IdentityDbContext<UserModel>
    {
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<ChatRoomModel> Rooms { get; set; }
        public DbSet<ReportMessageModel> Reports { get; set; }
        public DbSet<AanmeldModel> Aanmelding { get; set; }
        public DbSet<Caregiver> Caregiver { get; set; }
        public DbSet<UserModel> User { get; set; }
        
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        public Context(){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChatRoomModel>()
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
        }
    }
}