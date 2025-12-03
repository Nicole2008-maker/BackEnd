using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

//acao padrao inicial c
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();//retorna a pagina Minha.Acao.cshtml
    }
    
    public IActionResult ListaNomes()
    {

        string[] nomes = { "Nikki", "Day", "Isabella", "Rafael", "Ariel" };
        ViewBag.Teste = "Olá, eu vim através da ViewBag";
        ViewBag.nomes = nomes;
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
