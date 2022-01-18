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
        public DbSet<ChatRoomModel> Rooms {get;set;}
        
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        public Context(){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}