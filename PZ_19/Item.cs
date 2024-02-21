using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double ShippingCost { get; set; }
        public virtual double CalculateShippingCost()
        {
            // Просто возвращает стоимость доставки товара без каких-либо изменений
            return ShippingCost;
        }

        // Перегрузка операторов сравнения по полю стоимости доставки
        public static bool operator ==(Item item1, Item item2)
        {
            return item1.ShippingCost == item2.ShippingCost;
        }

        public static bool operator !=(Item item1, Item item2)
        {
            return item1.ShippingCost != item2.ShippingCost;
        }

        public static bool operator >(Item item1, Item item2)
        {
            return item1.ShippingCost > item2.ShippingCost;
        }

        public static bool operator <(Item item1, Item item2)
        {
            return item1.ShippingCost < item2.ShippingCost;
        }

        public static bool operator >=(Item item1, Item item2)
        {
            return item1.ShippingCost >= item2.ShippingCost;
        }

        public static bool operator <=(Item item1, Item item2)
        {
            return item1.ShippingCost <= item2.ShippingCost;
        }

        // Перегрузка операторов + и - для подсчета общего веса товаров
        public static double operator +(Item item1, Item item2)
        {
            return item1.Weight + item2.Weight;
        }

        public static double operator -(Item item1, Item item2)
        {
            return item1.Weight - item2.Weight;
        }
    }

}
