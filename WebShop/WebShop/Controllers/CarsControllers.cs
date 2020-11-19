using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Interfaces;
using WebShop.ViewModels;

/*************************************************************************
**************************************************************************

        Центральным звеном в архитектуре ASP.NET Core MVC является контроллер. 
При получении запроса система маршрутизации выбирает для обработки запроса 
нужный контроллер и передает ему данные запроса. Контроллер обрабатывает 
эти данные и посылает обратно результат обработки.

        В ASP.NET Core MVC контроллер представляет обычный класс на языке C#, 
который наследуется от абстрактного базового класса 
Microsoft.AspNetCore.Mvc.Controller. 

        По умолчанию проект ASP.NET Core MVC содержит как минимум один 
контроллер - HomeController:

https://metanit.com/sharp/aspnet5/5.1.php

************************************************************************
************************************************************************/

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
    }
}