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

    // setting up an object that can store multiple variables
    public class VariableContainer
    {
        // Example collections for each of your types
        public IEnumerable<QouteAcknowledgements.Models.Qoute> UnacknowledgedQoutes { get; set; }
        public IEnumerable<QouteAcknowledgements.Models.Qoute> AcknowledgedQoutes { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private QouteDBContext db = new QouteDBContext();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index(int? id)
        {
            // ok figured out actions, now to add some logic for transformations
            if (id != null)
            {
                // reset list
                if (id < 0)
                {
                    db.ResetData();
                }
                else
                {
                    db.AcknowledgeQuote((int)id);
                }
                // reinitialise data going to view
                db = new QouteDBContext();
            }
      
            // Build a view model
            var model = new VariableContainer()
            {

                // You'll likely want a .ToList() after these to ensure things work as expected
                UnacknowledgedQoutes = db.UnacknowledgedQoutes,
                AcknowledgedQoutes = db.AcknowledgedQoutes,
            };

            return View(model);
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
