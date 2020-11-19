using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Data.Models;

namespace WebShop.Data
{
    public class DBObjects
    {
        //public static void Initial(IApplicationBuilder app)
       
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                new Car
                    {
                        name = "Tesla sport",
                        shortDesc = "электропылесос",
                        longDesc = "дерзкий как пуля резкий ",
                        img = "/img/tesla_sport.jpg", 
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобиль"]
                    },
                    new Car
                    {
                        name = "BMW",
                        shortDesc = "красивая",
                        longDesc = "дерзкая как кобра",
                        img = "/img/bmw.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классический автомобиль"]
                    },
                    new Car
                    {
                        name = "MERCEDES",
                        shortDesc = "простая тачка",
                        longDesc = "большая но с ужасным сервисом даже кто-то сжег",
                        img = "/img/mers.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классический автомобиль"]
                    },
                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "кроссовер",
                        longDesc = "большая машинка с крыльями",
                        img = "/img/tesla-model-x-submodel.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобиль"]
                    }
                );
            }

                content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
            public static Dictionary<string, Category> Categories
            {
                get {
                    if (category == null)
                    {
                        var list = new Category[]
                        {
                            new Category {categoryname = "Электромобиль", desc = "Современный вид транспорта"},
                            new Category
                            {
                                categoryname = "Классический автомобиль", desc = "Машины с двигателем внутреннего згорания"
                            }
                        };
                        category = new Dictionary<string, Category>();
                        foreach (Category el in list)
                        {
                            category.Add(el.categoryname, el);
                        }
                    }
                    return category;
            }
        }
    }
}
