using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    internal class DataLayer : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DataLayer()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ShopTest;Trusted_Connection=True");
        }
    }


    public static class DB 
    {
        public static List<User> Users { get; set; }
        public static List<Product> Products { get; set; }

        static DB()
        {

            User u1 = new User() { Name = "Вася" };
            Users = new List<User>();
            Users.Add(u1);




            Products = new List<Product>();

            Products.Add(new Product() { Id = 1, Name = "Хлеб", Users = new List<User> {u1 } });
            Products.Add(new Product() { Id = 2, Name = "Чебуреки", Users = new List<User> {u1 } });
        }

    }
}
