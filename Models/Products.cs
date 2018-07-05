using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLangaugeFeature.Models
{
    public class Products
    {
        public Products(bool stock = true)
        {
            Instock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Products Related { get; set; }
        public bool Instock { get;}
        public static Products[] GetProducts()
        {
            Products P1 = new Products { Name = "Kayka",Category="Water Craft" ,Price = 275M };
            Products P2 = new Products(false) { Name = "lIFE", Price = 48.95M };
            P1.Related = P2;
            return new Products[] { P1, P2, null };
        }
    }
}
