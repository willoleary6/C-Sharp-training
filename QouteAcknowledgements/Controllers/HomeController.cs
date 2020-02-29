using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QouteAcknowledgements.Models;

namespace QouteAcknowledgements.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private QouteDBContext db = new QouteDBContext();
        private Qoute TestQuote = new Qoute();

 
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Debug.WriteLine("test!");
        }

        public IActionResult Index()
        {
            Debug.WriteLine("Action result!");
   
            var TestQuote = new Qoute { QouteID = 0, QouteText = "Shakespeare", QuoteAcknowledment = false };
            /* remove me when adding the sql stuff */
            foreach (var entity in db.UnacknowledgedQoutes)
                db.UnacknowledgedQoutes.Remove(entity);
            db.SaveChanges();

            db.UnacknowledgedQoutes.Add(TestQuote);
            db.SaveChanges();
            
            return View(db.UnacknowledgedQoutes.ToList());
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
