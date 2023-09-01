using NAC_Aircraft_Checklist.Models.Email;
namespace NAC_Aircraft_Checklist.Data.Services.Email
{
    public interface IEmailService
    {
        //Add User
        //Get User by Id 
        //public EmailRecipient GetById(int id);
       // public Task<IEnumerable<EmailRecipient>> GetAll();
        //public void Update(int id, EmailRecipient recipientUpdate);
       // public void Delete(int id);

        public void AddPlannerRecipient(PlannerRecipient recipient);
        public void UpdatePlannerRecipient(PlannerRecipient recipientUpdate);
        public PlannerRecipient GetRecipientPlannerById(int id);
        public Task<IEnumerable<PlannerRecipient>> GetAllPlannerRecipients();
        public void RemovePlannerRecipient(PlannerRecipient recipient);
        public void RemovePlannerRecipient(int id);
        public bool PlannerRecipientExists(string emailAddress);

        public void AddEscalationRecipient(EscalationRecipient recipient);
        public void UpdateEscalationRecipient(EscalationRecipient recipientUpdate);
        public EscalationRecipient GetEscalationRecipientById(int id);
        public Task<IEnumerable<EscalationRecipient>> GetAllEscalationRecipients();
        public void RemoveEscalationRecipient(EscalationRecipient recipient);
         public void RemoveEscalationRecipient(int id);
        public bool EscalationRecipientExists(string emailAddress);


        public void AddBaseManagerRecipient(BaseManagerRecipient recipient);
        public void UpdateBaseManagerRecipient(BaseManagerRecipient recipientUpdate);
        public BaseManagerRecipient GetBaseManagerRecipientById(int id);
        public Task<IEnumerable<BaseManagerRecipient>> GetAllBaseManagerRecipients();
        public void RemoveBaseManagerRecipient(BaseManagerRecipient recipient);
        public void RemoveBaseManagerRecipient(int id);
        public bool BaseManagerRecipientExists(string emailAddress);

        public void AddToUploadWaitList(BaseManagerRecipient baseManager);
        public void AddAllToUploadWaitList(List<BaseManagerRecipient> baseManagers);
        public void RemoveFromUploadWaitList(BaseManagerRecipient baseManager);
        public void RemoveFromUploadWaitList(string emailAddress);
        public Task<IEnumerable<UploadWaitList>> GetUploadWaitList();


        //Update User
        //Delete User

    }
}
