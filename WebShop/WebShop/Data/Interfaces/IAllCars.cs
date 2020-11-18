using System.Collections.Generic;
using WebShop.Data.Models;
using WebShop.Data.Repository;
using System.Threading.Tasks;


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