using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class AanmeldModel
    {
        public int Id { get; set; }

        [Required]
        public UserModel CareGiver { get; set; }

        [Required]
        public UserModel User { get; set; }

    }
}