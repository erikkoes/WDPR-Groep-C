using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class ChatRoomModel
    {
        public int Id {get; set;}

        [Required]
        [StringLength(40, MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string RoomName { get; set; }

        [Required]
        public string UsersJSON { get; set; }
    }
}