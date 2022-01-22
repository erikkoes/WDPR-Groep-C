using System.Collections.Generic;
namespace src.Models
{
    public class Caregiver
    {
        public int Id { get; set; }
        
        public ICollection<UserAanmelding> aanmeldingen { get; set; }
    }
}