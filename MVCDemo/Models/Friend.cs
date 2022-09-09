using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Friend
    {
        public int FriendID { get; set; }

        [Required]
        public string FName { get; set; }
        public string FPlace { get; set; }

    }
}
