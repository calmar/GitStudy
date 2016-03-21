using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using GitStudy.Helper;

namespace GitStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationEnvironment _appEnvironment;

        public HomeController(IApplicationEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;

        }
        public IActionResult Index( )
        {
            ViewBag.AdditionalInfo = "Additional information";
            var filePath = Path.Combine(_appEnvironment.ApplicationBasePath, "css", "site.css");
            var content = IoHelper.ReadFile(filePath);
            return View( );
        }

        public IActionResult About( )
        {
            ViewData["Message"] = "Your application description page.";

            return View( );
        }

        public IActionResult Contact( )
        {
            ViewData["Message"] = "Your contact page.";

            return View( );
        }

        public IActionResult Error( )
        {
            return View( );
        }
    }
}
