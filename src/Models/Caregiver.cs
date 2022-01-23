using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class Caregiver
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public UserModel User { get; set; }
        
        public ICollection<AanmeldModel> Aanmeldingen { get; set; }
    }
}