using System.Collections.Generic;
using WebShop.Data.Models;

namespace WebShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
    }
}