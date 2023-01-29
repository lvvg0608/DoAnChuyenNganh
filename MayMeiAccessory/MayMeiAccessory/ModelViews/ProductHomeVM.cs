using MayMeiAccessory.Models;
using System;
using System.Collections.Generic;

namespace MayMeiAccessory.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
