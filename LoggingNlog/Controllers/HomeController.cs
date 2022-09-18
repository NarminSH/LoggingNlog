using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoggingNlog.Models;
using NLog;
using NLog.Web;

namespace LoggingNlog.Controllers;

public class HomeController : Controller
{

    Logger logger = LogManager.GetCurrentClassLogger();

    public IActionResult Index()
    {
        try
        {
            int a = 0;
            int b = 2;
            int c = b / a;
        }
        catch (Exception ex)
        {
            logger.Error("hello this is index");
            logger.Error("Divided by zero occured in Home controller home page", ex);
        }
        return View();
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

