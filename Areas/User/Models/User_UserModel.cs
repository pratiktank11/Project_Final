using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


    public class User_UserModel
    {
        public int UserId { get; set; }

        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        public string isAdmin { get; set; }
    }

