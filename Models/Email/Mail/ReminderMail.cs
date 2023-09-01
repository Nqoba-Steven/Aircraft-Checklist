namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class ReminderMail
    {
        public ReminderMail(string to, string aircraftReg)
        {
            this.To = to;
            this.AircraftReg = aircraftReg;
        }
        public string Subject
        {
            get
            {
                return $"Reminder: Aircraft Checklist Uploaded for {this.AircraftReg}";
            }
        }
        public string Body
        {
            get
            {
                string body = 
                $"Hello,\r\n\r\nA new checklist has been uploaded for {this.AircraftReg}" +
                $"\r\nThe checklist and Proof Read Checklist is available in the link below" +
                $"\nClick link below" +
                $"\r\nhttps://acform.nac.co.za" +
                $"\n\nKind Regards NAC Aircraft Checklist";

                return body;
            }

        }
        //DocumentID for proofread
        public string AircraftReg { get; set; }

        public string To { get; set; }

    }
}
