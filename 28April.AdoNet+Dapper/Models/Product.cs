using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28April.AdoNet_Dapper.Models
{
    class Product
    {
        public Product(string name, decimal price, int categoryId)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
        }

        public int Id {  get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId {  get; set; }


        public Product()
        {
            
        }
    }
    
}
