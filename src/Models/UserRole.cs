using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    public class UserRole : IdentityUserRole<string>
    {
        public UserModel User { get; set; }
        public RoleModel Role { get; set; }
    }
}