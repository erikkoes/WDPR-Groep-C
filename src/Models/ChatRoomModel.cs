using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class ChatRoom
    {
        // public ChatRoom() {
        //     Users = new List<ChatUser>();
        // }
        
        public int Id { get; set; }

        [Required]
        //[StringLength(40, MinimumLength = 4)]
       // [RegularExpression("^[a-zA-Z ]*$")]
       
        public string RoomName { get; set; }

        public string RoomSubject { get; set; }

        public ICollection<ChatUser> Users { get; set; }
        
        public ICollection<MessageModel> Messages { get; set; }
    }
}