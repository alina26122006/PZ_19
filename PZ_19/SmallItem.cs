using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class SmallItem : Item
    {
        public override double CalculateShippingCost()
        {
            return ShippingCost * 0.8;
        }
    }
}
