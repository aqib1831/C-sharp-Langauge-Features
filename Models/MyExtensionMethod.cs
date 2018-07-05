using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLangaugeFeature.Models
{
    public static  class MyExtensionMethod
    {
        public static decimal TotalPrices(this IEnumerable<Products> products) {
            decimal total = 0;
            foreach(Products prod in products)
            {
                total = prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Products> FilterByPrice(this IEnumerable<Products> productEnum,decimal minPrice)
        {
            foreach (var p in productEnum)
            {
                if ((p?.Price ?? 0) >= minPrice)
                {
                    yield return p;
                }
            }
        }
    }
}
