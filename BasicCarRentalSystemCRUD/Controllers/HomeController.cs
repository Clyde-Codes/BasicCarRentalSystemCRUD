using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicCarRentalSystemCRUD.Models;

namespace BasicCarRentalSystemCRUD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Management()
    {
        return View();
    }
    
    public IActionResult CreateEditUser()
    {
        return View();
    }

    public IActionResult CreateEditUserForm(CarRenter model)
    {
        return RedirectToAction("Management"); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
