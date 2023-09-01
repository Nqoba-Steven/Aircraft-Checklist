namespace NAC_Aircraft_Checklist.Services.Mail
{
    public class NACMail
    {

        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public NACMail()
        {
        }
        public NACMail(string to, string subject, string message)
        {
            To = to;
            Subject = subject;
            Message = message;
        }
        public NACMail(string subject, string message)
        {
            Subject = subject;
            Message = message;
        }
        public override string ToString()
        {
            return $"NAC Mail: \n\tTo: {this.To}\n\t \n\tSubject: {this.Subject} \n\tMessage: {this.Message}";
        }
    }
}
