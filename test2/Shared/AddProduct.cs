using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.Shared
{
    public class AddProduct
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public AddProduct(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public AddProduct()
        {

        }
    }
}
