using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DataLayer
{
    public interface IRestore<T>
    {
        void Create(T product);
        void Delete(T product);
        void Update(T product);
        IEnumerable<T> ShowAll();
        T Find(string name);
        T Find(int id);
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }



    public class Entity : IRestore<Product>
    {
        public void Create(Product product)
        {
            DB.Products.Add(product);
        }

        public void Delete(Product product)
        {
            DB.Products.Remove(product);
        }

        public void Update(Product product)
        {
            var find = DB.Products.FirstOrDefault(x => x.Name == product.Name);
            if (find != null)
            {
                find = product;
            }
        }

        public Product Find(string name)
        {
            var find = DB.Products.FirstOrDefault(x => x.Name == name);
            if(find != null)
            {
                return find;
            }

            return null;
        }

        public Product Find(int id)
        {
            var find = DB.Products.FirstOrDefault(x => x.Id == id);
            if (find != null)
            {
                return find;
            }

            return null;
        }

        public IEnumerable<Product> ShowAll()
        {
            return DB.Products.OrderBy(x => x.Name).ToList();
        }
    }










    public class User
    {
        public string Name { get; set; }
    }

    
}
