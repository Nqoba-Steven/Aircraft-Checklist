namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class EscalationMail
    {
        public EscalationMail(string uploadedBy, string aircraftReg)
        {
            this.UploadedBy = uploadedBy;
            this.AircraftReg = aircraftReg;
        }
        public string Subject
        {
            get
            {
                return "A New Aircraft Checklist Update Uploaded";
            }
        }
        public string Body
        {
            get
            {
                string body =
                $"Hello,\r\n\r\nOutstanding" +
                $"\nPlease complete the aircraft checklist on the website" +
                $"\r\nClick link below" +
                $"\r\nhttps://acform.nac.co.za" +
                $"\r\n\nKind Regards NAC Aircraft Checklist";
                return body;
            }
        }

        public string AircraftReg { get; set; }

        public string UploadedBy { get; set; }
    }
}
