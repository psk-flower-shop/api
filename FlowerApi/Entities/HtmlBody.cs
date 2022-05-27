namespace FlowerApi.Entities
{
    public class HtmlBody
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
       
        public HtmlBody()
        {
        }

        public HtmlBody(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

    }
}
