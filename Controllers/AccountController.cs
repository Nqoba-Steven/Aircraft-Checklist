using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NAC_Aircraft_Checklist.Areas.Identity.Pages.Account;
using NAC_Aircraft_Checklist.Models.Users;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult CreateAccount()
        {

            return View();
        }
        public IActionResult Register(RegisterModel registerModel)
        {


            return View();
        }

    }
}
