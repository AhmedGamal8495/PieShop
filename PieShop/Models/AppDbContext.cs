using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "cheese cake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "seasonal pies" });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "apple",
                Price = 12.32M,
                ShortDes = "short description",
                LongDes = "Long description",
                CategoryId = 1,
                ImgUrl = "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1",
                InStock = true,
                IsPieOfTheWeek = true

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "orange",
                Price = 12.32M,
                ShortDes = "short description",
                LongDes = "Long description",
                CategoryId = 3,
                ImgUrl = "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1",
                InStock = true,
                IsPieOfTheWeek = true

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "cake",
                Price = 12.32M,
                ShortDes = "short description",
                LongDes = "Long description",
                CategoryId = 2,
                ImgUrl = "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1",
                InStock = true,
                IsPieOfTheWeek = true

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "cake",
                Price = 12.32M,
                ShortDes = "short description",
                LongDes = "Long description",
                CategoryId = 2,
                ImgUrl = "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1",
                InStock = true,
                IsPieOfTheWeek = true

            });



        }
    }
}
