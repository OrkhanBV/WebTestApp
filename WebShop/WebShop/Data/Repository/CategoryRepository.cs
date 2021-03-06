using System.Collections.Generic;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Repository
{
    
    public class CategoryRepository : ICarsCategory 
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}