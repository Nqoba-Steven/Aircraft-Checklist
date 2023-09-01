namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class SuccessfulUploadMail
    {
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
                $"Hello,\r\n\r\nYour checklist for {this.AircraftReg} has been successfully upload  " +
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
