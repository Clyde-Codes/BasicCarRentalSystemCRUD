using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicCarRentalSystemCRUD.Models;

namespace BasicCarRentalSystemCRUD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ManagementDbContext _context;

    public HomeController(ILogger<HomeController> logger, ManagementDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Management()
    {
        
        var allManagement = _context.Management.ToList();
        return View(allManagement);
    }
    
    public IActionResult CreateEditUser(int? id)
    {
        if(id != null)
        {
            var managementInDb = _context.Management.SingleOrDefault(renter => renter.Id == id);
            return View(managementInDb);
        }

        
        return View();
    }

    public IActionResult Delete(int id)
    {
        var managementInDb = _context.Management.SingleOrDefault(renter => renter.Id == id);
        _context.Management.Remove(managementInDb);
        _context.SaveChanges();
        return RedirectToAction("Management");
    }

    public IActionResult CreateEditUserForm(CarRenter model)
    {
        if (model.Id == 0)
        {
            _context.Management.Add(model);
        } else
        {
            _context.Management.Update(model);
        }
            _context.SaveChanges();
            return RedirectToAction("Management"); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
