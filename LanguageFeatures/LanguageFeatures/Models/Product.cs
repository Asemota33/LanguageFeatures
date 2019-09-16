﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public static Product[] GetProducts() {
            Product kayak = new Product { Name = "Kayak", Price = 175M };
            Product lifeJacket = new Product { Name = "lifeJacke", Price = 48.9M };
            return new Product[] { kayak, lifeJacket, null };
        }

    }
}
