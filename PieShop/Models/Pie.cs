using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; }
        public string ShortDes { get; set; }
        public string LongDes { get; set; }
        public string AllergyInfo { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public string Notes { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }




    }
}
