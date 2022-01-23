using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    public class UserModel : IdentityUser
    {
        // public ICollection<UserRole> UserRoles { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        // public AanmeldModel Aanmelding { get; set; }

        // public int AanmeldingId { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        #nullable enable
        public Caregiver? Caregiver { get; set; }
    }
}