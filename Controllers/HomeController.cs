using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase_4.Models;
using Clase_4.Services;

namespace Clase_4.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {

    }

    public IActionResult Index()
    {   
        var model = new List<Pelicula>();
        model = ServicioPeli.GetAll();

        return View(model);
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
