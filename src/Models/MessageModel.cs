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
        public string message{get;set;}
        [Required]
        public string UserName{get;set;}
        [Required]
        public int ChatRoomId {get;set;}
        public int UserId{get;set;}       
        public DateTime date{get;set;}
        public ICollection<ChatUser> Users { get; set; }
        

    }
}