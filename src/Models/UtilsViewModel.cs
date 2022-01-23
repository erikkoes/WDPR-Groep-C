using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    public class UtilsViewModel
    {
        public UserModel User { get; set; }

        public IEnumerable<string> CurrentRoles { get; set; }

        public IEnumerable<RoleModel> Roles { get; set; }

        public IEnumerable<UserModel> AllUsers { get; set; }
    }
}