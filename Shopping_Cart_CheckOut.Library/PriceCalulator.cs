using Shopping_Cart_CheckOut.Library.Model;
using System;
using System.Collections.Generic;

namespace Shopping_Cart_CheckOut.Library
{
    public class PriceCalculator
    {
        /// <summary>
        /// Calculate Total Price as per Products
        /// </summary>
        /// <param name="_products"></param>
        /// <returns></returns>
        public decimal CalculateTotalPrice(IList<Product> _products)
        {
            decimal price = 0;
            try
            {
                foreach (Product itemProd in _products)
                {
                    int _count = itemProd.Quantity;
                    int _discountCount = itemProd.DiscoutEligibleQuantity;
                    decimal _pricePerOne = itemProd.UnitPrice;
                    decimal _discountPrice = itemProd.BulkPrice;

                    switch (itemProd.ProductCode)
                    {
                        case "A":
                        case "C":
                            while (_count >= _discountCount)
                            {
                                price += _discountPrice;
                                _count -= _discountCount;
                            }
                            price += _pricePerOne * _count;
                            break;
                        case "B":
                        case "D":
                            price += _pricePerOne * _count;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return price;
        }
    }
}
