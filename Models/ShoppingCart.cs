using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLangaugeFeature.Models
{
    public class ShoppingCart:IEnumerable<Products>

    {
        public IEnumerable<Products> Products { get; set; }

        public IEnumerator<Products> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
