using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;
public interface ISliderItemService
{
    SliderItem GetSliderItemById(int id);
    Task<List<SliderItem>> GetAllSliderItemsAsync();

    Task CreateSliderItemAsync(SliderItem sliderItem);
    void UpdateSliderItem(int id, SliderItem sliderItem);
    Task HardDeleteSliderItemAsync(int id);
    Task SoftDeleteSliderItemAsync(int id);
}