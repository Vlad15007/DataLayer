using BLL;
using DataLayer;
using System.Collections.Generic;

namespace MVC.Models
{
    public class IndexData
    {
        public IEnumerable<Product> Products { get; set; }
        UnregisteredUser user = new UnregisteredUser();

        public IndexData()
        {
            Products = user.ShowAllProducts();
        }
    }
}
