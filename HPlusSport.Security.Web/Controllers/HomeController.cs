using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;
/*Course: 		Web Programming 3
* Assessment: 	Milestone 4
* Created by: 	David Lynch - 2275556
* Date: 		14/11/2024
* Class Name: 	HomeController.cs
* Description: 	The home controller that handles overall logic to do with the homescreen.
* Time Task B):	3
 */
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
