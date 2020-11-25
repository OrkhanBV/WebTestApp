using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebShop.Data.Interfaces;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllCars _allCars;

        public HomeController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
        }


        public ViewResult Index()
        {
            CarsListViewModel obj = new CarsListViewModel();
            //obj.allCars = _allCars.Cars;
            obj.allCars = _allCars.CarsElectro;
            //obj.allCars = _allCars.getLastCar;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}