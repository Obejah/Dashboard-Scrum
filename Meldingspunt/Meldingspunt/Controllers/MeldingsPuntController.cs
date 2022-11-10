using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using Meldingspunt.Services;
using Microsoft.Extensions.Primitives;
using System.Linq;

namespace Meldingspunt.Controllers;

public class MeldingsPuntController : Controller
{
    private PointService pointService;
    public MeldingsPuntController()
    {
        pointService = new PointService(5);
        pointService.CreateConnection("localhost", "Meldingspunt", @"OBEJAH-LAPTOP\obeja", "");
    }
    public IActionResult Index()
    {

        List<Models.Point> testDblist = pointService.GetAll().Cast<Models.Point>().ToList();

       

        
        //var meldingspunten = service.GetAll();
        
        //if (meldingspunten != null && meldingspunten.Any())
        //{
            //var result = (List<Meldingspunt.Models.MeldingsPunt>)meldingspunten;

        //}
   
        return View(testDblist);
    }


}