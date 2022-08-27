using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    _PieListViewModel pieListViewModel = new _PieListViewModel();
        //    pieListViewModel.Pies = _pieRepository.AllPies;

        //    pieListViewModel.currentCategory = "Cheese Cake";
        //    return View(pieListViewModel);
        //}

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (id == null)
                return NotFound();
            return View(pie);
        }

        public IActionResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All Pies";
            }
            else 
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);

                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).ToString();
            }

            return View(new _PieListViewModel {
                Pies = pies,
                currentCategory = currentCategory
            }) ;
        }
    }
}
