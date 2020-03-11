using System;
using System.Collections.Generic;

namespace Shopping_Cart_CheckOut.Library.Model
{
    public class ProductDB
    {
        /// <summary>
        /// Load all the Product Data 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Product> ProductDetails() => new Dictionary<string, Product>()
            {
                { "A", new Product{ ProductCode ="A", UnitPrice = Convert.ToDecimal(1.25),
                     BulkPrice = Convert.ToDecimal(3.00),
                     DiscoutEligibleQuantity=3} },
                { "B", new Product{ ProductCode ="B", UnitPrice = Convert.ToDecimal(4.25),
                    DiscoutEligibleQuantity=0 } },
                { "C", new Product{ ProductCode ="C", UnitPrice = Convert.ToDecimal(1.00),
                    BulkPrice = Convert.ToDecimal(5.00),
                    DiscoutEligibleQuantity=6 } },
                { "D", new Product{ ProductCode ="D", UnitPrice = Convert.ToDecimal(0.75),
                    DiscoutEligibleQuantity=0} }
            };
    }
}
