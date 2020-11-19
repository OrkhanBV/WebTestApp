using System.Collections.Generic;
using WebShop.Data.Models;
using WebShop.Data.Repository;
using System.Threading.Tasks;
/*************************************************************************
**************************************************************************

    Интерфейс представляет ссылочный тип, который может определять некоторый 
функционал - набор методов и свойств без реализации. Затем этот функционал 
реализуют классы и структуры, которые применяют данные интерфейсы.
    
https://metanit.com/sharp/tutorial/3.9.php

************************************************************************
************************************************************************/

namespace WebShop.Data.Interfaces
{
    public interface IAllCars
    {
        /*IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjectCar(int carId);*/
        

            IEnumerable<Car> Cars { get; }
            IEnumerable<Car> getFavCars { get; }
            Car getObjectCar(int carId);
            
    }
}