using System.Collections.Generic;
namespace NAC_Aircraft_Checklist.Models.Email.Mail
{
    public class RichMail
    {
        public RichMail() { }   
        public string From {get;set;}
        public string To {get;set; }
        public string Subject {get;set; }
        public  List<string> ImagePaths = new List<string> { 
            "~/img/ticketmaster/dstv.png",
            "~/img/ticketmaster/ticket.jpeg",
             "~/img/ticketmaster/Map.jpg",
            "~/img/ticketmaster/logo2.jpg", };
        public string Body { get;set;}
    }
}
