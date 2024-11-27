using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Models;
using Pronia.MVC.Areas.ProniaAdmin.ViewModels;

namespace Pronia.MVC.Areas.ProniaAdmin.Controllers;

[Area("ProniaAdmin")]
public class SliderItemController : Controller
{
    public readonly ISliderItemService _sliderItemService;

    public SliderItemController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public async Task<IActionResult> Index()
    {
        List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
        return View(sliderItems);
    }
    public async Task <IActionResult> Info(int id)
    {
        SliderItem sliderItem=await _sliderItemService.GetSliderItemByIdAsync(id);
        return View(sliderItem);
    }
    [HttpGet]
    public IActionResult Create()
    { 
    return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(SliderItemCreateVM sliderItemCreateVM)
    {
        if (!ModelState.IsValid)
        { 
        return View(sliderItemCreateVM);
        }
        SliderItem sliderItem = new SliderItem()
        {
            Title = sliderItemCreateVM.Title,
            ShortDescription = sliderItemCreateVM.ShortDescription,
            Offer = sliderItemCreateVM.Offer,
            ImgPath = sliderItemCreateVM.ImgPath,
            CreatedDate = DateTime.Now,

        };
        await _sliderItemService.CreateSliderItemAsync(sliderItem);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Uptade(int id)
    {
        SliderItem sliderItem = await _sliderItemService.GetSliderItemByIdAsync(id);
        return View(sliderItem);
    }
    [HttpPost]
    public async Task<IActionResult> Uptade(int id,SliderItem sliderItem)
    {
        if (!ModelState.IsValid)
        {
            return View(sliderItem);
        }
        await _sliderItemService.UpdateSliderItemAsync(id, sliderItem);
        return RedirectToAction(nameof(Index));
    }
}
