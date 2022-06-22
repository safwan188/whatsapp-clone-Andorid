namespace real.Models
{
    public class Message
    {
        public int Id { get; set; }
        public String contactId { get; set; }
        public String content { get; set; }
        public String created { get; set; }
        public bool sent { get; set; }
    }
}
