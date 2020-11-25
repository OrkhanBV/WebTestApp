using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Repository
{
    public class CarRepository : IAllCars {

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
     



        public IEnumerable<Car> Cars => appDBContent.Car.Where(p => p.name  == "BMW");
        /*var users = (from user in db.Users.Include(p=>p.Company)
            where user.CompanyId == 1
            select user).ToList();*/
        //public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        
        //public Car Cars => appDBContent.Car.Where(First);
        //public Car getLastCar => appDBContent.Car.First(p => p.Category.categoryname == "Электромобиль");

        public IEnumerable<Car> CarsElectro => appDBContent.Car.Where(p => p.Category.categoryname == "Электромобиль");
        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
    
}
/*{
    public abstract class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}*/