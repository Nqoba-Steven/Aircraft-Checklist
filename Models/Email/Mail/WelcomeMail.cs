namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class WelcomeMail
    {
        public WelcomeMail(string to) { 
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
                    $"Hello {FullName}" +
                    $"\n\nWe have implemented a new electronic form that is to be used for completing the aircraft checklists." +
                    $"\r\nThis will hopefully improve response times and allow for electronic flagging and escalations where issues/variations appear in the completed the lists." +
                    $"\r\n\nPlease see the instructions attached, and your individual login details below:" +
                    $"\r\n\n\r\n\nhttps://acform.nac.co.za" +
                    $"\r\n\nUsername: {Username}" +
                    $"\r\nPassword: {Password}" +
                    $"\r\nYour account Role: {Role}" +
                    $"\r\n\nIn the event of a loss of internet connectivity at the base, the completed PDF file will still be the backup solution, and direct communication with the CAMO department will be required." +
                    $"\r\nFor any IT related queries please log a call by emailing helpdesk@nac.co.za or call +27 11 267 5560";
                
                return body;
            }

        }

    }
}
