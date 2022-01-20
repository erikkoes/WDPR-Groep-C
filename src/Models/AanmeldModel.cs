using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class AanmeldModel
    {
        public int Id {get; set;}
        [Required]
        public string CareGiverId { get; set; }
        [Required]
        
        public string UserId { get; set; }

    }
}