using Hangfire;
using Microsoft.AspNetCore.Mvc;
using NAC_Aircraft_Checklist.Services.Jobs;
using NAC_Aircraft_Checklist.Services.Mail;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class JobController : Controller
    {
        private readonly INACEmailSender _emailSender;
        private readonly IJobService _jobService;
        private readonly IBackgroundJobClient _backgroundJobClient;
        private readonly IRecurringJobManager _recurringJobManager;

        public JobController(IJobService jobService, IBackgroundJobClient backgroundJobClient, IRecurringJobManager recurringJobManager, INACEmailSender emailSender)
        {
            _jobService = jobService;
            _backgroundJobClient = backgroundJobClient;
            _recurringJobManager = recurringJobManager;
            _emailSender = emailSender;

        }
        [HttpGet("/Job/FireAndForget")]
        public IActionResult FireAndForget()
        {
            _backgroundJobClient.Enqueue(() => _jobService.FireAndForgetJob());
            return Ok();
        }
        [HttpGet("/Job/Delayed")]
        public IActionResult Delayed(int seconds)
        {

            _backgroundJobClient.Schedule(() => _jobService.DelayedJob(),TimeSpan.FromSeconds(seconds));
            return Ok();
        }
        [HttpGet("/Job/Recurring")]
        public IActionResult Recurring()
        {
            //Run this mail 3 times
            //Monthly 21st 10 pm
            _recurringJobManager.AddOrUpdate("jobId",() => _jobService.RecurringJob(), Cron.Monthly(21,10));
            return Ok();
        }
        [HttpGet("/Job/Continuation")]
        public IActionResult Continuation()
        {
            var parentJobId = _backgroundJobClient.Enqueue(() => _jobService.FireAndForgetJob());
            _backgroundJobClient.ContinueJobWith(parentJobId, () => _jobService.ContinuationJob());

            return Ok();
        }
    }
}
