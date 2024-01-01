using Microsoft.AspNetCore.Mvc;
using CSServer.Models;

namespace CSServer.Controllers;

public class HomeController : Controller
{
   public IActionResult Index() {
    int hour = DateTime.Now.Hour;
    string viewModel = hour < 12 ? "Good Morning Milton's CSharp" : "Good Afternoon Milton's CSharp";
    return View("MyView", viewModel);
   }

    [HttpGet]
   public ViewResult ProjForm() {
    return View();
   }

   [HttpPost]
   public ViewResult ProjForm(MyProjects myprojects) {
    Repository.AddResponse(myprojects);
    return View("Thanks", myprojects);
   }

   public ViewResult ListResponses() {
    return View(Repository.Responses.Where(r => r.Completed == true));
   }
}
