using Microsoft.AspNetCore.Mvc;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.MVC.Controllers;

public class HomeController : Controller
{
    public readonly ProniaDBContext _context;
    public HomeController()
    {
        _context= new ProniaDBContext();
    }
    public IActionResult Index()
    {
        List<SliderItem> sliderItems=_context.SliderItems.ToList();
        return View(sliderItems);
    }
}
