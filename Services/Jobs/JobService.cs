using NAC_Aircraft_Checklist.Data;
using NAC_Aircraft_Checklist.Services.Mail;

namespace NAC_Aircraft_Checklist.Services.Jobs
{
    public class JobService : IJobService
    {
        private readonly INACEmailSender _emailSender;

        public JobService(INACEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        public void ContinuationJob()
        {
            NACMail toDarryl = new NACMail("darryl.griffith@nac.co.za", "Scheduled Test Mail", "This is a scheduled Test Mail sending mails by the minute");
            //_emailSender.SendEmailAsync(toDarryl);
            NACMail toSteven = new NACMail("steven.novukuza@nac.co.za", "Scheduled Test Mail", "This is a scheduled Test Mail sending mails by the minute");
            _emailSender.SendEmailAsync(toSteven);
            System.Diagnostics.Debug.WriteLine("Hello from aContinuation Job");
        }

        public void DelayedJob()
        {
            System.Diagnostics.Debug.WriteLine("Hello from a Delayed Job");
        }

        public void FireAndForgetJob()
        {
            NACMail toDarryl = new NACMail("darryl.griffith@nac.co.za", "Once off Test Mail", "This is a Once off Test Mail sent only once");
            //_emailSender.SendEmailAsync(toDarryl);
            NACMail toSteven = new NACMail("steven.novukuza@nac.co.za", "Once off Test Mail", "This is a Once off Test Mail sent only once");
            _emailSender.SendEmailAsync(toSteven);

            System.Diagnostics.Debug.WriteLine("Hello from a Fire and Forget Job");
        }

        public void RecurringJob()
        {
            NACMail toDarryl = new NACMail("darryl.griffith@nac.co.za", "Scheduled Test Mail", "This is a scheduled Test Mail sending mails by the minute");
            //_emailSender.SendEmailAsync(toDarryl);
            NACMail toSteven = new NACMail("steven.novukuza@nac.co.za", "Scheduled Test Mail", "This is a scheduled Test Mail sending mails by the minute");
            _emailSender.SendEmailAsync(toSteven);
            System.Diagnostics.Debug.WriteLine("Hello from a Recurring Job");
        }
    }
}
