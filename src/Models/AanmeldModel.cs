using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class AanmeldModel
    {
        public int Id {get; set;}
        [Required]
        public UserModel CareGiverId { get; set; }
        [Required]
        
        public UserModel UserId { get; set; }

    }
}