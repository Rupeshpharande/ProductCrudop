using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudop
{
    //it is entity class
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} , {Name} ,{Price}";

        }
    }
}
