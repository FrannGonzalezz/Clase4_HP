using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase_4.Models;
using Clase_4.Services;

namespace Clase_4.Controllers;

public class MoviesController : Controller
{
    public MoviesController()
    {

    }

    public IActionResult Index()
    {
        var modelo2 = new List<Pelicula>();
        modelo2 = ServicioPeli.GetAll();
        return View(modelo2);
    }

    public IActionResult Detalle(int id)
    {
        var model = ServicioPeli.Get(id);
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
