namespace NAC_Aircraft_Checklist.Models.RND
{
    public class B1900Interior
    {
        abstract class BaseInterior {
            public string Description { get; set; }
            public string Status { get; set; }
            public string Commment { get; set; }
        }
        class CockpitSeats { 
            //How revisions will be handled
            //Schema B1900Interior.CockpitSeats
            //ID
            //Entry ID -> Used to track all the entries by document (entryID = documentID)
            //string Description
            //string Status
            //string comments
        }
    }
}
