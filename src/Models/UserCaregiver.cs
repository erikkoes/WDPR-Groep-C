namespace src.Models
{
    public class UserCaregiver
    {
        public int Id { get; set; }

        public UserModel User { get; set; }

        public Caregiver Caregiver { get; set; }
    }
}