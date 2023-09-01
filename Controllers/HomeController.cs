using NAC_Aircraft_Checklist.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using NAC_Aircraft_Checklist.Models;
using System.Diagnostics;
using NAC_Aircraft_Checklist.Services.Mail;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.Email;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NAC_Aircraft_Checklist.Models.Users;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class HomeController : Controller
    {
        private readonly INACEmailSender _emailSender;
        private readonly IEmailService _emailService;
        private readonly IAircraftService _aircraftService;
        public HomeController(INACEmailSender emailSender, IEmailService emailService, IAircraftService aircraftService)
        {
            _emailService = emailService;
            _emailSender = emailSender;
            _aircraftService = aircraftService;
        }

        [Authorize]
        public IActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("Move back");
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            System.Diagnostics.Debug.WriteLine("Move back");
            return View();
        }
        const string AdminUsername = "admin";
        const string AdminPassword = "@dmin@N@C";
        const string UserPassword = "forms@NAC";
        bool CheckUserExistence(string emailAddress, string password)
        {

            if (String.Equals(emailAddress, AdminUsername, StringComparison.CurrentCultureIgnoreCase) && String.Equals(password, AdminPassword))
            {
                return true;
            }
            bool flag;

            flag = _emailService.BaseManagerRecipientExists(emailAddress);
            if (flag)
            {
                return flag;
            }
            flag = _emailService.PlannerRecipientExists(emailAddress);
            if (flag)
            {
                return flag;
            }
            flag = _emailService.EscalationRecipientExists(emailAddress);
            if (flag)
            {
                return flag;
            }
            return false;
        }
        public class LoginPayload
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public override string ToString()
            {
                return $"Username: {this.Username} Password: {this.Password}";
            }
        }
        [HttpPost]
        public async Task<IActionResult> LoginAttempt()
        {
            //Check the planners
            //Check aircrafts
            //Check Escalation
            //Admin password @dmin@N@C

            System.Diagnostics.Debug.WriteLine("Move back");

            var r = HttpContext.Request;
            LoginPayload mypayload;
            using (var reader = new StreamReader(r.Body))
            {
                //Read JSON
                string content = await reader.ReadToEndAsync();
                mypayload = JsonConvert.DeserializeObject<LoginPayload>(content);
                System.Diagnostics.Debug.WriteLine(mypayload);
            }
            /*
            bool isAuthorized = CheckUserExistence(mypayload.Username, mypayload.Password);
            if (!isAuthorized)
                return Unauthorized();
            System.Diagnostics.Debug.WriteLine($"Username: {mypayload.Username} Password: {mypayload.Password} Authorised:{isAuthorized}");
            */
            //Create a Cookie
            var claims = new List<Claim>();
            claims.Add(new Claim("Username", mypayload.Username));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, mypayload.Username));
            var claimsId = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsId);
            await HttpContext.SignInAsync(claimsPrincipal);
            System.Diagnostics.Debug.WriteLine("Signing in now");

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}