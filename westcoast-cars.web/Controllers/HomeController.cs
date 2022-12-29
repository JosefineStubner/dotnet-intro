using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

//namespace utan måsvingar standard för .Net6 =>
namespace westcoast_cars.web.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Message = "Vi har bilen för dig och din familj";
        //returnerar ett view result
        return View("Index");
    }
}
