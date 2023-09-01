using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Data;
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.Email;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Email.Mail;
using NAC_Aircraft_Checklist.Models.Email.Recipients;
using NAC_Aircraft_Checklist.Models.Entities;
using NAC_Aircraft_Checklist.Services.Mail;
using static NAC_Aircraft_Checklist.Controllers.HomeController;

namespace NAC_Aircraft_Checklist.Controllers
{
    public class AircraftController : Controller
    {
        // GET: Aircraft
        private readonly INACEmailSender  _emailSender;
        private readonly IEmailService _emailService;
        private readonly IAircraftService _service;
        public AircraftController(INACEmailSender emailSender, IEmailService emailService, IAircraftService service)
        {
            _emailService = emailService;
            _emailSender = emailSender;
            _service = service;
        }
        public async Task<ActionResult> Index()
        {

            ViewData["Aircrafts"] = await _service.GetAll();
            var aircrafts = ViewData["Aircrafts"];
            System.Diagnostics.Debug.WriteLine(aircrafts);

            return View();
        }

        // GET: Aircraft/Details/5

        // GET: Aircraft/Create
        [HttpPost]
        public async Task<IActionResult> Create()
        {

            try
            {
                HttpContext context = HttpContext;
                var req = context.Request;
                var res = context.Response;
                Aircraft newAircraft;
                using (var reader = new StreamReader(req.Body))
                {
                    //Read JSON
                    string content = await reader.ReadToEndAsync();
                    newAircraft = Newtonsoft.Json.JsonConvert.DeserializeObject<Aircraft>(content);
                    System.Diagnostics.Debug.WriteLine(newAircraft);

                    if (!_service.Exists(newAircraft.Reg))
                    {
                        //Send Mail
                        _service.Add(newAircraft);
                        SendWelcomeEmail(newAircraft.EmailAddress);
                        //Add new BaseManager

                        var success = new { success = "Aircraft Successfully Created" };
                        var jsonSuccess = JsonSerializer.Serialize(success);
                        context.Response.StatusCode = 201;
                        context.Response.ContentType = "application/json";
                        await Response.WriteAsync(jsonSuccess);
                        System.Diagnostics.Debug.WriteLine("We have created the aircraft");
                    }
                    else
                    {
                        var err = new { error = "could not create aircraft, it already exists" };

                        var jsonErr = JsonSerializer.Serialize(err);
                        context.Response.StatusCode = 400;
                        context.Response.ContentType = "application/json";
                        await Response.WriteAsync(jsonErr);
                        System.Diagnostics.Debug.WriteLine("Could not create Record: Aircraft already exists");
                    }
                }

                return new EmptyResult();
                ///:RedirectToAction(nameof(HomeController.Index), "Home");
                //req.Body.WriteAsync("{Try:Again}");

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        async void SendWelcomeEmail(string emailAddress) {
            WelcomeMail welcomeMail = new WelcomeMail(emailAddress);
           await _emailSender.SendEmailAsync(emailAddress, welcomeMail.Subject, welcomeMail.Message);
        }
        // GET: Aircraft/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Aircraft"] = _service.GetById(id);
            Aircraft model = new Aircraft();
            return View(model);
        }

        public ActionResult Update(int id,Aircraft updateAircraft)
        {
            //If Email changed Send welcome mail

            Aircraft original = _service.GetById(id);
            bool hasEmailChanged = String.Equals(original.EmailAddress, updateAircraft.EmailAddress,StringComparison.OrdinalIgnoreCase);

            if (!hasEmailChanged) {
                SendWelcomeEmail(updateAircraft.EmailAddress);
            }

            Aircraft aircraft = _service.Update(id,updateAircraft);

            return Redirect("/Aircraft");
        }

        // POST: Aircraft/Edit/5


        // GET: Aircraft/Delete/5
        public ActionResult Delete(int id)
        {
            //Get the id
            _service.Delete(id);
            return Redirect("/Aircraft");
        }

        // POST: Aircraft/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
