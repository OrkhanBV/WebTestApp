using System;
using Microsoft.EntityFrameworkCore;
using WebShop.Data.Models;

namespace WebShop.Data
{
    //Данный класс является классом подключения к базе данных
    public class AppDBContent : DbContext {

            public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
            
            }

            public DbSet<Car> Car { get; set; }
            public DbSet<Category> Category { get; set; }

    }
}