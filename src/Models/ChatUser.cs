using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace src.Models
{
    public class ChatUser
    {
        public ChatRoom ChatRoom { get; set; }

        public UserModel User { get; set; }

        [Key, Column(Order = 1)]
        public string UserId { get; set; }

        [Key, Column(Order = 0)]
        public int ChatRoomId { get; set; }
    }
}