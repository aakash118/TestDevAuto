using System;
using System.Collections.Generic;

#nullable disable

namespace TestDevInfrastructure.models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public string CategoryList { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
