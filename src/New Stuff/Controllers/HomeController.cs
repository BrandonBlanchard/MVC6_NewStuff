using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using New_Stuff.Models;
using New_Stuff.Services;
using New_Stuff.ViewModels;

namespace New_Stuff.Controllers
{
    public class HomeController : Controller
    {
        public ICupService cupService { get; set; }

        public IEmailSender emailSender { get; set; }

        public HomeController(ICupService _cupService, IEmailSender _emailSender)
        {
            cupService = _cupService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ACupForOne()
        {
            CupTradeViewModel model = new CupTradeViewModel();

            model.CupChoices = cupService.GetCups();

            return View(model);
        }

        [HttpPost]
        public IActionResult ACupForOne(CupTradeViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            EmailModel email = EmailBuilder.Construct(EmailDefaults.DebugRecipient, EmailDefaults.DefaultTitle, model.GetAll());

            emailSender.SendEmailAsync(email.To, email.Title, email.Body);

            return RedirectToAction("ACupForOneConfirmation", model);
        }

        public IActionResult ACupForOneConfirmation(CupTradeViewModel model)
        {
            return View(model);
        }

        public IActionResult HowItWorks()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
