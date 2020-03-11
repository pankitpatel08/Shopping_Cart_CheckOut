using Shopping_Cart_CheckOut.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Cart_CheckOut.Library
{
    public class PointOfSaleTerminal : Product
    {
        private readonly Dictionary<string, Product> _productDict = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public PointOfSaleTerminal()
        {
            _productDict = ProductDB.ProductDetails();
        }

        /// <summary>
        /// Scan Product as per added in Shopping Cart
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public IList<Product> ScanProduct(string productCode)
        {
            IList<Product> _finalProduct = new List<Product>();
            try
            {
                foreach (char code in productCode.ToUpper())
                {
                    var productList = _productDict.Where(p => p.Key == Convert.ToString(code));

                    // if product not in list then null
                    if (productList.Count() > 0)
                    {
                        Product objProduct = new Product
                        {
                            ProductCode = productList.FirstOrDefault().Value.ProductCode,
                            UnitPrice = Convert.ToDecimal(productList.FirstOrDefault().Value.UnitPrice),
                            BulkPrice = Convert.ToDecimal(productList.FirstOrDefault().Value.BulkPrice),
                            DiscoutEligibleQuantity = Convert.ToInt32(productList.FirstOrDefault().Value.DiscoutEligibleQuantity)
                        };

                        var isExists = _finalProduct.Where(e => e.ProductCode == Convert.ToString(code));
                        if (isExists.Count() == 0)
                            _finalProduct.Add(objProduct);
                        else
                            isExists.FirstOrDefault().Quantity++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _finalProduct;
        }
    }
}
