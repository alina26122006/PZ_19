using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class MediumItem : Item
    {
        // Переопределяем метод для расчета условий доставки товара
        public override double CalculateShippingCost()
        {
            // Увеличиваем стоимость доставки на коэффициент 1,0
            return ShippingCost * 1.0;
        }
    }
}
