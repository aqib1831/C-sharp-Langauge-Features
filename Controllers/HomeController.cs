using CSharpLangaugeFeature.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLangaugeFeature.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Products[] productArray = {
            new Products {Name = "Kayak", Price = 275M},
            new Products {Name = "Lifejacket", Price = 48.95M},
            new Products {Name = "Soccer ball", Price = 19.50M},
            new Products {Name = "Corner flag", Price = 34.95M}
            };
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            //ShoppingCart cart = new ShoppingCart { Products = Products.GetProducts() };
            //Products[] productArray = {
            //                           new Products {Name = "Kayak", Price = 275M},
            //                           new Products {Name = "Lifejacket", Price = 48.95M}
            //                          };
            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();
            //return View("Index", new string[] {
            //$"Cart Total: {cartTotal:C2}",
            //$"Array Total: {arrayTotal:C2}" });
            //decimal cartTotal = cart.TotalPrices();
            //List<string> result = new List<string>();
            //foreach(var x in Products.GetProducts())
            //{
            //    string name = x?.Name??"<No Name>";
            //    decimal? price = x?.Price ?? 0;
            //    string relatedName = x?.Related?.Name??"<No Name>";
            //    result.Add($"Name: {name} ,Price:{price},Related : {relatedName}");
            //}
            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        }
    }
    }

