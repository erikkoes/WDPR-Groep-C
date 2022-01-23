using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class AanmeldModel
    {
        public int Id { get; set; }

        public int CaregiverId { get; set; }
        
        [Required]
        public Caregiver Caregiver { get; set; }

        [Required]
        public UserModel User { get; set; }

        public string UserId { get; set; }
    }
}