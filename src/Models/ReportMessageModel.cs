using System.ComponentModel.DataAnnotations;

namespace src.Models{
    public class ReportMessageModel {
        [Key]
        public string ReportId{get;set;}
        [Required]
        public string UserId{get;set;}
        [Required]
        public string Message{get;set;}

    }
}