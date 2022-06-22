using System.ComponentModel.DataAnnotations;

namespace real.Models
{
    public class Contact
    {
        [Key]
        public String contName { get; set; }
        public String userId { get; set; }
        public String name { get; set; }
        public String server { get; set; }

    }
}
