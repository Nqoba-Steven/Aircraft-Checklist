using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class HangfireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
         [Route("[action]")]
        public IActionResult Welcome() {
            var jobId = BackgroundJob.Enqueue(() => FireForgetJob("Fire and forget job"));
            return Ok($"Job ID: {jobId} Fire and forget Message");
        }

        public void FireForgetJob(string msg) {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
