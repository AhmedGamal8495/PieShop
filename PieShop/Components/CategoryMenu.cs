using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Components
{
    public class CategoryMenu:ViewComponent
    {
        private readonly ICategoryRepository _categoryrepository;

        public CategoryMenu(ICategoryRepository categoryrepository)
        {
            _categoryrepository = categoryrepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryrepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }

}
