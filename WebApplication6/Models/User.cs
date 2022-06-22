using System.ComponentModel.DataAnnotations;

namespace real.Models
{
    public class User

    {
        public String Name { get; set; }
        [Key]
         public String username { get; set; }
        public String Password { get; set; }
        public String? server { get; set; }
        public String image { get; set; }
    }
}
