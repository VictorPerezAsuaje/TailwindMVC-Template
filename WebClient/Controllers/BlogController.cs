using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebClient.Models;

namespace WebClient.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BlogController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}