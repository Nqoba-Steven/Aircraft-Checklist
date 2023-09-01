using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Email.Logger;

namespace NAC_Aircraft_Checklist.Data.Services.Email
{
    public interface IEmailLoggerService
    {
        public void LogWelcome(WelcomeLog log);
        public WelcomeLog GetWelcomeLogById(int id);
        public Task<IEnumerable<WelcomeLog>> GetAllWelcomeLogs();


        public void LogReminder(ReminderLog log);
        public ReminderLog GetReminderLogById(int id);
        public Task<IEnumerable<ReminderLog>> GetAllReminderLogs();


        public void LogUpload(UploadLog log);
        public UploadLog GetUploadLogById(int id);
        public Task<IEnumerable<UploadLog>> GetAllUploadLogs();


        public void LogEscalation(EscalationLog log);
        public EscalationLog GetEscalationLogById(int id);
        public Task<IEnumerable<EscalationLog>> GetAllEscalationLogs();


        public void LogProof(ProofLog log);
        public ProofLog GetProofLogById(int id);
        public Task<IEnumerable<ProofLog>> GetAllProofLogs();


        public void LogRevision(RevisionLog log);
        public RevisionLog GetRevisionLogById(int id);
        public Task<IEnumerable<RevisionLog>> GetAllRevisionLogs();
        //Get User by Id 
    }
}
