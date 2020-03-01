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

       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Debug.WriteLine("test!");
        }

        

        public IActionResult Index(int? id)
        {
            // ok figured out actions, now to add some logic for transformations
            if (id != null)
            {
                // reset list
                if (id < 0)
                {
                    db.reset();
                }
                Debug.WriteLine("Well cowboy " + id);
                // reinitialise data going to view
                db = new QouteDBContext();
            }
            
            return View(db.UnacknowledgedQoutes);
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
