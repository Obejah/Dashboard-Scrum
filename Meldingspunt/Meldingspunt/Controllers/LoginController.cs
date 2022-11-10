using Microsoft.AspNetCore.Mvc;
using Meldingspunt.Services;
// using NuGet.Protocol.Plugins;

namespace Meldingspunt.Controllers
{
    public class LoginController : Controller
     {
         private UserService userService = new UserService();

         LoginController()
        {
             //userService.CreateConnection(localhost, meldingspunt, root, root);
         }

         [HttpGet]
         public IActionResult Login()
         {
            return View();
         }

         public ActionResult Verify()
         {
             string dummymail = "hehehaha@gmail.com";
             string dummypw = "hohoho";

            /* //User user = userService.GetByMail("hehehaha@gmail.com").FirstOrDefault();
             if (user != null)
             {
                 if (user.Password == dummypw)
                 {
                    //login !
                 }
                 else
                 {
                     //fout ww
                 }
             }
             else
             {
                 // fout mail
             }*/

             return View();
         }
     }
 }