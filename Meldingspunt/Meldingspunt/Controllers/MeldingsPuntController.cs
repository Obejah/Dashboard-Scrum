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
    MeldingsPuntController()
    {
        pointService = new PointService(0);
        pointService.CreateConnection("localhost", "meldinspunt", "root", "root");
    }
    public IActionResult Index()
    {

        List<Models.MeldingsPunt> testDblist = pointService.GetAll().Cast<Models.MeldingsPunt>().ToList();

        List<Models.MeldingsPunt> myList = new List<Models.MeldingsPunt>();

        Models.MeldingsPunt firstMeldingspunt = new Models.MeldingsPunt();
        firstMeldingspunt.Name = "First";
        firstMeldingspunt.Id = 1;

        Models.MeldingsPunt secondMeldingspunt = new Models.MeldingsPunt();
        secondMeldingspunt.Name = "Second";
        secondMeldingspunt.Id = 1;

        myList.Add(firstMeldingspunt);
        myList.Add(secondMeldingspunt);

        
        //var meldingspunten = service.GetAll();
        
        //if (meldingspunten != null && meldingspunten.Any())
        //{
            //var result = (List<Meldingspunt.Models.MeldingsPunt>)meldingspunten;

        //}
   
        return View(myList);
    }


}