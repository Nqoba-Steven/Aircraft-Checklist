using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NAC_Aircraft_Checklist.Data.Services.Email;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Models.Email;
using NAC_Aircraft_Checklist.Models.Email.Mail;
using NAC_Aircraft_Checklist.Models.Email.Recipients;
using NAC_Aircraft_Checklist.Services.Mail;
using System.Net.Mail;
using System.Net.Mime;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly INACEmailSender _emailSender;
        private readonly IWebHostEnvironment _env;

        public EmailController(IEmailService emailService, INACEmailSender emailSender, IWebHostEnvironment env)
        {
            _emailService = emailService;
            _emailSender = emailSender;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            //ViewData["EmailRecipients"] = await _emailService.GetAll();
            ViewData["UploadWaitList"] = await _emailService.GetUploadWaitList();
            ViewData["BaseManagerRecipient"] = await _emailService.GetAllBaseManagerRecipients();
            ViewData["EscalationRecipient"] = await _emailService.GetAllEscalationRecipients();
            ViewData["PlannerRecipient"] = await _emailService.GetAllPlannerRecipients();

            return View();
        }

        public async Task<ActionResult> SendTestMail() {
            NACMail mail = new NACMail();
            mail.Subject ="Test";
            mail.Message ="Test";

           await _emailSender.SendEmailAsync("steven.novukuza@nac.co.za", mail);
            return Redirect("/");
        }
        public async Task<IActionResult> Add(EmailRecipientPayload payload)
        {
            //Welcome Mail
            NACMail mail = new NACMail();
            mail.Subject = "Welcome to the NAC Aircraft Checklist Service";
            mail.Message = $"Welcome \nClick link to get started http://acform.nac.co.za";

            if (payload.isPlanner)
            {
                _emailService.AddPlannerRecipient(payload.PlannerRecipient);
                await _emailSender.SendEmailAsync(payload.PlannerRecipient.EmailAddress, mail);
                System.Diagnostics.Debug.WriteLine("Planner Created");
                System.Diagnostics.Debug.WriteLine(payload.PlannerRecipient);
            }
            if (payload.isBaseManager)
            {
                _emailService.AddBaseManagerRecipient(payload.BaseManagerRecipient);
                await _emailSender.SendEmailAsync(payload.BaseManagerRecipient.EmailAddress, mail);
                //Send Welcome Mail
                System.Diagnostics.Debug.WriteLine("BaseManager Created");
                System.Diagnostics.Debug.WriteLine(payload.BaseManagerRecipient);
            }
            if (payload.isEscalation)
            {
                _emailService.AddEscalationRecipient(payload.EscalationRecipient);
                await _emailSender.SendEmailAsync(payload.EscalationRecipient.EmailAddress, mail);
                System.Diagnostics.Debug.WriteLine("Escalation Created");
                System.Diagnostics.Debug.WriteLine(payload.EscalationRecipient);
            }
            //ViewData["EmailRecipients"] = await _emailService.GetAll();
            return Redirect("/Email/");
        }

        public IActionResult Create(string type)
        {
            EmailRecipientPayload model = new EmailRecipientPayload();
            switch (type.ToLower())
            {
                case "basemanager":
                    model.isBaseManager = true;
                    model.isPlanner = false;
                    model.isEscalation = false;
                    break;
                case "planner":
                    model.isPlanner = true;
                    model.isBaseManager = false;
                    model.isEscalation = false;
                    break;
                case "escalation":
                    model.isEscalation = true;
                    model.isPlanner = false;
                    model.isBaseManager = false;
                    break;
                default:
                    break;
            }
            return View(model);
        }
        public IActionResult Edit(string type, int id)
        {
            EmailRecipientPayload model = new EmailRecipientPayload();
            try
            {
                switch (type.ToLower())
                {
                    case "basemanager":
                        ViewData["OriginalBaseManager"] = _emailService.GetBaseManagerRecipientById(id);
                        break;
                    case "planner":
                        ViewData["OriginalPlanner"] = _emailService.GetRecipientPlannerById(id);
                        break;
                    case "escalation":
                        ViewData["OriginalEscalation"] = _emailService.GetEscalationRecipientById(id);
                        break;
                    default:
                        break;
                }
                // ViewData["Original"] = _emailService.GetById(id);
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err);
            }
            return View(model);
        }

        public IActionResult Update(string type, EmailRecipientPayload payload)
        {
            try
            {
                switch (type)
                {
                    case "basemanager":
                        BaseManagerRecipient b = new BaseManagerRecipient();
                        b.Id = payload.PlannerRecipient.Id;
                        b.Name = payload.PlannerRecipient.Name;
                        b.EmailAddress = payload.PlannerRecipient.EmailAddress;
                        _emailService.UpdateBaseManagerRecipient(b);
                        break;
                    case "planner":
                        PlannerRecipient p = new PlannerRecipient();
                        p.Id = payload.PlannerRecipient.Id;
                        p.Name = payload.PlannerRecipient.Name;
                        p.EmailAddress = payload.PlannerRecipient.EmailAddress;
                        _emailService.UpdatePlannerRecipient(p);
                        break;
                    case "escalation":
                        EscalationRecipient e = new EscalationRecipient();
                        e.Id = payload.EscalationRecipient.Id;
                        e.Name = payload.EscalationRecipient.Name;
                        e.EmailAddress = payload.EscalationRecipient.EmailAddress;
                        _emailService.UpdateEscalationRecipient(e);
                        break;
                    default:
                        break;
                }
                //_emailService.Update(id, recipient);
                System.Diagnostics.Debug.WriteLine("Update Successful");
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err);
            }

            return Redirect("/Email/");
        }

        public IActionResult ComposeEmail() {
            RichMail mail = new RichMail();

            return View(mail);
        }

        public IActionResult SendRichMail(RichMail mail) {

            using (var msg = new MailMessage())
            {

                msg.From = new MailAddress(mail.From);
                msg.To.Add(new MailAddress(mail.To));
                msg.Subject = mail.Subject;

                msg.IsBodyHtml = true;

                var inlineImages = new List<LinkedResource>();
                string[] arr = { 
                     "/img/ticketmaster/dstv.png",
                    "/img/ticketmaster/ticket.jpeg",
                    "/img/ticketmaster/Map.jpg",
                    "/img/ticketmaster/logo2.jpg",
                };

                var i = 0;
                   List<string> ImagePaths = new List<string> {
                    "~/img/ticketmaster/dstv.png",
                    "~/img/ticketmaster/ticket.jpeg",
                     "~/img/ticketmaster/Map.jpg",
                    "~/img/ticketmaster/logo2.jpg", };
                foreach (var image in ImagePaths)
                {
                    System.Diagnostics.Debug.WriteLine(image);
                    var imgResource = new LinkedResource(Path.Combine("wwwroot/", arr[i]),MediaTypeNames.Image.Jpeg);
                    imgResource.ContentId = Guid.NewGuid().ToString();
                    inlineImages.Add(imgResource);
                    mail.Body = mail.Body.Replace(image, "cid:" + imgResource.ContentId);
                    i++;

                }
                var view = AlternateView.CreateAlternateViewFromString(mail.Body, null, "text/html");
                foreach (var inlineImage in inlineImages)
                {
                    view.LinkedResources.Add(inlineImage);
                }
                msg.AlternateViews.Add(view);
                _emailSender.SendMail(msg);
            }
            return Redirect("/");
        }
        
        public IActionResult Delete(string type, int id)
        {
            //System.Diagnostics.Debug.WriteLine($"ID:{id}");
            // _emailService.Delete(id);
            switch (type)
            {
                case "basemanager":
                    _emailService.RemoveBaseManagerRecipient(id);
                    break;
                case "planner":
                    _emailService.RemovePlannerRecipient(id);
                    break;
                case "escalation":
                    _emailService.RemoveEscalationRecipient(id);
                    break;
                default:
                    break;
            }
            return Redirect("/Email/");
        }
    }
}
