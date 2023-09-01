using System.Net.Mail;
using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Email.Mail;

namespace NAC_Aircraft_Checklist.Services.Mail
{
    public interface INACEmailSender
    {
        Task SendEmailAsync(string email,string subject, string msg);
        Task SendEmailAsync(NACMail mail);
        Task SendWelcomeMail(WelcomeMail mail);
        Task SendNewUserMail(NewUserMail mail);
        Task SendUploadMail(string to,ChecklistUploadMail mail);
        Task SendEmailAsync(string to, NACMail mail);
        public void SendMail(MailMessage mail);

        Task SendEmailsAsync(List<string> recipients ,NACMail mail);

    }
}
