using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Meldingspunt.Controllers
{
    public class Point : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
