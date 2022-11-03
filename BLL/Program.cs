using DataLayer;
using System;
using System.Collections.Generic;

namespace BLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity find = new Entity();

            find.Create(new Product() { Id = 2, Name = "Соль", Users = new List<User>()});

            var tover = find.Find("Соль");

            Console.WriteLine(tover.Id);
        }


    }


    public class UnregisteredUser
    {
        public IEnumerable<Product> FindProduct()
        {
            Entity entity = new Entity();
            foreach (var item in entity.ShowAll())
            {
                yield return item;
            }
        }

        public IEnumerable<Product> ShowAllProducts()
        {
            Entity entity = new Entity();
            return entity.ShowAll();
        }
    }

    public class RegisteredUser : UnregisteredUser
    {
        public void Buy()
        {
            
        }
    }

    public class Admin : RegisteredUser
    {
        public void Stop()
        {

        }
    }
}
