

using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Interfaces;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";

            return View(obj);
        }

        /*public class CarsController : Controller
            {
                private readonly IAllCars _allCars;
                private readonly ICarsCategory _allCategories;
                //Создаем конструктор
                public CarsController(IAllCars iAllCars, ICarsCategory iCarCat)
                {
                    _allCars = iAllCars;
                    _allCategories = iCarCat;
                }
    
                public ViewResult List()
                {
                    ViewBag.Title = "Странница с автомобилями";
                    CarsListViewModel obj = new CarsListViewModel();
                    obj.allCars = _allCars.Cars;
                    obj.currCategory = "Автомобили";
                    return View(obj);
                }
            }*/
    }
}