using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal discountSize;
        private decimal discountParam;

        public DefaultDiscountHelper(decimal totalParam)
        {
            discountSize = discountParam;
        }        

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountSize /100m * totalParam));
        }
    }
}