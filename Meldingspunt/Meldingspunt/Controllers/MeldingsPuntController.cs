using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using Meldingspunt.Services;
using Microsoft.Extensions.Primitives;
using System.Linq;

namespace Meldingspunt.Controllers;

public class MeldingsPuntController : Controller
{
<<<<<<< HEAD
    public PointService pointService;
    public MeldingsPuntController()
    {
        pointService = new PointService(0);
        pointService.CreateConnection("127.0.0.1", "meldingspunt", "root", "root");
=======
    private PointService pointService;
    public MeldingsPuntController()
    {
        pointService = new PointService(5);
        pointService.CreateConnection("localhost", "Meldingspunt", @"OBEJAH-LAPTOP\obeja", "");
>>>>>>> ca078ef6e034f09695fedaf2259ef27da50ee4b4
    }
    public IActionResult Index()
    {

        List<Models.Point> testDblist = pointService.GetAll().Cast<Models.Point>().ToList();

<<<<<<< HEAD
        List<Models.MeldingsPunt> myList = new List<Models.MeldingsPunt>();

        // Models.MeldingsPunt firstMeldingspunt = new Models.MeldingsPunt();
        // firstMeldingspunt.Name = "First";
        // firstMeldingspunt.Id = 1;
        //
        // Models.MeldingsPunt secondMeldingspunt = new Models.MeldingsPunt();
        // secondMeldingspunt.Name = "Second";
        // secondMeldingspunt.Id = 1;
        //
        // myList.Add(firstMeldingspunt);
        // myList.Add(secondMeldingspunt);
=======
       
>>>>>>> ca078ef6e034f09695fedaf2259ef27da50ee4b4

        
        //var meldingspunten = service.GetAll();
        
        //if (meldingspunten != null && meldingspunten.Any())
        //{
            //var result = (List<Meldingspunt.Models.MeldingsPunt>)meldingspunten;

        //}
   
        return View(testDblist);
    }


}