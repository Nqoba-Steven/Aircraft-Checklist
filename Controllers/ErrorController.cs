using Microsoft.AspNetCore.Mvc;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error(string msg)
        {
            return View(msg);
        }
    }
}
