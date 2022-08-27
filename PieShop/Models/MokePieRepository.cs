using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MokePieRepository : IPieRepository
    {
        private readonly ICategoryRepository _cat = new MokeCategoryRepository();
        
        public IEnumerable<Pie> AllPies => new List<Pie>
            {
                new Pie{PieId=1, CategoryId=1, Name="Straw Pie" , Price=15.25M, ShortDes="this is short discribtion",LongDes="this is short discribtion",IsPieOfTheWeek=true},
                new Pie{PieId=3,CategoryId=2, Name="Cheese Cake" , Price=12.33M, ShortDes="this is discribtion",LongDes="this is short discribtion",IsPieOfTheWeek=true},
                new Pie{PieId=2, CategoryId=3,Name="Rhubarb Pie" , Price=17M, ShortDes="this is discribtion",LongDes="this is short discribtion",IsPieOfTheWeek=true},
                

            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            var result = AllPies.FirstOrDefault(p => p.PieId == pieId);
            return result;
        }
    }
}
