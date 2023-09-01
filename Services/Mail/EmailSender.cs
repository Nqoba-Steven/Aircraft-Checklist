using Humanizer;
using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Email.Mail;
using System.Net;
using System.Net.Mail;

namespace NAC_Aircraft_Checklist.Services.Mail
{
    public class EmailSender : INACEmailSender
    {
        private static int port = 25;
        private static string host = "172.21.37.70";
        private static string from = "tersia.smit@nac.co.za";
        private static string ServiceName = "no-reply-AircraftCheckList@nac.co.za";

        public async Task SendEmailAsync(string sendTo, string subject, string msg)
        {
            try
            {
                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password)
                };
                System.Diagnostics.Debug.WriteLine("Sending mail");
                await client.SendMailAsync(
                   new MailMessage(
                       from: from,
                       to: sendTo,
                       subject,
                       msg));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public  void SendMail(MailMessage mail)
        {
            try
            {

                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password)
                };
                 client.Send(mail);
            }
            catch (Exception e) { 
            
            }

        }
        public async Task SendEmailAsync(NACMail mail)
        {
            try
            {

                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password)
                };
                System.Diagnostics.Debug.WriteLine("Sending mail");
                await client.SendMailAsync(
                    new MailMessage(
                        from: from,
                        to: mail.To,
                        subject: mail.Subject,
                        body: mail.Message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task SendEmailAsync(string to, NACMail mail)
        {
            try
            {

                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password),


                };
                System.Diagnostics.Debug.WriteLine("Sending mail");
                await client.SendMailAsync(
                    new MailMessage(
                        from: from,
                        to: to,
                        subject: mail.Subject,
                        body: mail.Message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task SendEmailsAsync(List<string> recipients, NACMail mail)
        {
            foreach (var recipient in recipients)
            {
                await SendEmailAsync(recipient, mail);
            }
        }

        public async Task SendNewUserMail(NewUserMail mail)
        {
            try
            {

                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password),


                };
                System.Diagnostics.Debug.WriteLine("Sending welcome mail");
                await client.SendMailAsync(
                    new MailMessage(
                from: ServiceName,
                        to: mail.To,
                        subject: mail.Subject,
                        body: mail.Message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task SendUploadMail(string to, ChecklistUploadMail mail)
        {
            try
            {
                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password),


                };
                System.Diagnostics.Debug.WriteLine("Sending Upload mail");
                await client.SendMailAsync(
                    new MailMessage(
                from: ServiceName,
                        to: to,
                        subject: mail.Subject,
                        body: mail.Message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public async Task SendWelcomeMail(WelcomeMail mail)
        {
            try
            {

                var client = new SmtpClient(host, port)
                {
                    EnableSsl = false,
                    UseDefaultCredentials = false
                    //Credentials = new NetworkCredential(username, password),


                };
                System.Diagnostics.Debug.WriteLine("Sending welcome mail");
                await client.SendMailAsync(
                    new MailMessage(
                from: ServiceName,
                        to: mail.To,
                        subject: mail.Subject,
                        body: mail.Message));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }

}
