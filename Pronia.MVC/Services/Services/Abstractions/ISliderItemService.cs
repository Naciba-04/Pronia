using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;
public interface ISliderItemService
{

    Task<List<SliderItem>> GetAllSliderItemsAsync();
}