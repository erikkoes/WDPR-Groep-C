using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    public class UserAanmelding
    {
        public UserModel user { get; set; }
        
        public AanmeldModel aanmeld{ get; set; }

        
    }
}