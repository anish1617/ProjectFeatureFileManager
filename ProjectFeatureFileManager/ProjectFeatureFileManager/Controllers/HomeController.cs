using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectFeatureFileManager.Models;
using ProjectFeatureFileManager.Data;
namespace ProjectFeatureFileManager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly SchoolContext _context;
    public HomeController(ILogger<HomeController> logger, SchoolContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var s = _context.Students?.Where(x => x.ID == 1).FirstOrDefault();
        return View(s);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
