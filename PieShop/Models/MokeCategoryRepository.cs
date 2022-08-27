using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MokeCategoryRepository : ICategoryRepository 
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Fruit Pies" , Des="All-Fruit"},
                new Category{ CategoryId=2, CategoryName="Cheese Cake" , Des="Cheesy"},
                new Category{ CategoryId=3, CategoryName="Seasonal Pies" , Des="Get in the mood for Seasonal Pies"}
            };
    }
}
