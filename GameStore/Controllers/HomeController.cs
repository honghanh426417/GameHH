using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;

namespace GameStore.Controllers;

public class HomeController : Controller
{
    private readonly GameStoreContext _context;

    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, GameStoreContext context)
    {
        _logger = logger;
        _context = context;
    }


    public IActionResult Index()
    {
        List<Product> products = _context.Products.ToList();

        return View(products);
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

