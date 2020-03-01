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
    public class ExampleViewModel
    {
        // Example collections for each of your types
        public IEnumerable<QouteAcknowledgements.Models.Qoute> CollectionA { get; set; }
        public IEnumerable<QouteAcknowledgements.Models.Qoute> CollectionB { get; set; }
    }

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
                else
                {
                    Debug.WriteLine("ACKING");
                    db.acknowledgeQuote((int)id);
                }
                Debug.WriteLine("Well cowboy " + id);
                // reinitialise data going to view
                db = new QouteDBContext();
            }
            /* for the moment I am just going to put them in a stack */

            // Build the model
            var model = new ExampleViewModel()
            {

                // You'll likely want a .ToList() after these to ensure things work as expected
                CollectionA = db.UnacknowledgedQoutes,
                CollectionB = db.AcknowledgedQoutes,
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
