using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Entities
{
    public class Product
    {
        //public int Id { get; set; }
        //public decimal Price { get; set; }
        //public decimal OriginalPrice { get; set; }
        //public int Stock { get; set; }
        //public int ViewCount { get; set; }
        //public DateTime DateCreated { get; set; }
        //public string SeoAlias { get; set; }

        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public bool? IsFeatured { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}
