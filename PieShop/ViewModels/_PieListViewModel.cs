using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class _PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

        public String currentCategory { get; set; }
    }
}
