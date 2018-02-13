using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate.GenericClasses
{
    public class DiscountCalculator<TProduct> where TProduct: Product
    {
        private static double discount = 0.5;
        public double CalculateDiscount(TProduct product)
        {
            return product.Price * discount;
        }
    }
}
