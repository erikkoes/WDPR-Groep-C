using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    public class RoleModel : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}