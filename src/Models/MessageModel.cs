using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;

namespace src.Models
{
    public class MessageModel
    {
        
        public int Id {get; set;}

        [Required]
        public string Message{get;set;}

        [Required]
        public string UserName{get;set;}

        [Required]
        public int ChatRoomId {get;set;}

        public string UserId{get;set;} 

        public DateTime Date{get;set;}

        public ICollection<ChatUser> Users { get; set; }
        

    }
}