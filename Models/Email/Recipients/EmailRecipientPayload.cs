namespace NAC_Aircraft_Checklist.Models.Email.Recipients
{
    public class EmailRecipientPayload
    {
        public PlannerRecipient PlannerRecipient { get; set; }
        public EscalationRecipient EscalationRecipient { get; set; }
        public BaseManagerRecipient BaseManagerRecipient { get; set; }

        public bool isPlanner { get; set; }
        public bool isEscalation{ get; set; }
        public bool isBaseManager{ get; set; }
    }
}
