using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET_Mom2.Models;
using Newtonsoft.Json;

namespace NET_Mom2.Controllers;

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

    [Route("/omsso")]
    public IActionResult About()
    {
        return View();
    }

    [Route("/dinahästar")]
    public IActionResult Horses()
    {
        // Läsa in JSON-fil
        var jsonStr = System.IO.File.ReadAllText("horses.json");
        // Konvertera från JSON till objekt
        var jsonObj = JsonConvert.DeserializeObject<IEnumerable<Horses>>(jsonStr);

        ViewBag.Horses = jsonObj;

        return View();
    }

    [HttpPost("/dinahästar")] // POST-anrop
    public IActionResult Horses(Horses model)
    {
        if(ModelState.IsValid) { // Om formulär är korrekt ifyllt
            // Läsa in JSON-fil
            var jsonStr = System.IO.File.ReadAllText("horses.json");
            // Konvertera
            var jsonObj = JsonConvert.DeserializeObject<List<Horses>>(jsonStr);

            if(jsonObj != null) { // Kontrollerar att filen ej är tom
                jsonObj.Add(model); // Lägger till häst
                System.IO.File.WriteAllText("horses.json", JsonConvert.SerializeObject(jsonObj, Formatting.Indented)); // Formatterar om
            }
        }

        return View();
    }

    [Route("/anteckningar")]
    public IActionResult Notes()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
