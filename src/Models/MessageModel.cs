using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System;

namespace src.Models
{
    public class MessageModel
    {
        
        public int Id {get; set;}
        [Required]
        public string message{get;set;}
        [Required]
        public string UserId{get;set;}
        [Required]
        public int ChatRoomId {get;set;}
        [Required]
        public DateTime date{get;set;}

    }
}