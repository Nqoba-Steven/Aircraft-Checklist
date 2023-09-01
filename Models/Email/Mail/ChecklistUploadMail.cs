namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class ChecklistUploadMail
    {
        public ChecklistUploadMail(string uploadedBy,string aircraftReg, string ProofReadDocId) {
            this.UploadedBy = uploadedBy;
            this.AircraftReg = aircraftReg;
            this.ProofReadDocumentID = ProofReadDocId;   
        }
        public string Subject
        {
            get
            {
                return $"New Aircraft Checklist Uploaded for {this.AircraftReg}";
            }
        }
        public string Message
        {
            get
            {
                string body = 
                $"Hello," +
                $"\r\n\r\nA new checklist has been uploaded for {this.AircraftReg} completed by {this.UploadedBy}" +
                $"\r\nThe checklist and Proof Read Checklist is available in the link below" +
                $"\nClick link below" +
                $"\r\nhttps://acform.nac.co.za" +
                $"\n\nKind Regards NAC Aircraft Checklist";

                return body ;
            }

        }
        //DocumentID for proofread
        public string ProofReadDocumentID { set;get; }
        public string AircraftReg { get; set; }

        public string UploadedBy { get; set; }
        public string DocumentId { get; set; }


    }
}
