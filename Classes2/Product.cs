﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    internal class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }          // Pascal Case yazım şekli
        public int UnitsInStock { get; set; }           // camel Case
    }
}
