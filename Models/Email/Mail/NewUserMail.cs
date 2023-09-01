namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class NewUserMail
    {
        public NewUserMail(string to)
        {
            To = to;
        }
        public string Subject
        {
            get
            {
                return "Welcome to NAC Aircraft Checklist";
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string To { get; set; }
        public string FullName { get; set; }
        public string Message
        {
            get
            {
                string body =
                    $"Hello {To}" +
                    $"\n\nA new User has been created " +
                    $"\r\n\n\r\n\nhttps://acform.nac.co.za" +
                    $"\r\n\nFull Name: {FullName}" +
                    $"\r\n\nUsername: {Username}" +
                    $"\r\nPassword: {Password}" +
                    $"\r\nAccount Role: {Role}";

                return body;
            }

        }
    }
}
