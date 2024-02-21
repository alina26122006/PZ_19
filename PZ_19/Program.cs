using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item { Name = "Товар 1", Weight = 155, Volume = 1, ShippingCost = 152 };
            Item item2 = new Item { Name = "Товар 2", Weight = 2, Volume = 2, ShippingCost = 200 };

            // Расчет стоимости доставки для каждого товара
            double shippingCost1 = item1.CalculateShippingCost();
            double shippingCost2 = item2.CalculateShippingCost();

            Console.WriteLine("Стоимость доставки товара 1: " + shippingCost1);
            Console.WriteLine("Стоимость доставки товара 2: " + shippingCost2);

            // Сравнение стоимости доставки товаров по операторам сравнения
            bool isEqual = item1 == item2;
            bool isNotEqual = item1 != item2;
            bool isGreater = item1 > item2;
            bool isLess = item1 < item2;
            bool isGreaterOrEqual = item1 >= item2;
            bool isLessOrEqual = item1 <= item2;

            Console.WriteLine("item1 == item2: " + isEqual);
            Console.WriteLine("item1 != item2: " + isNotEqual);
            Console.WriteLine("item1 > item2: " + isGreater);
            Console.WriteLine("item1 < item2: " + isLess);
            Console.WriteLine("item1 >= item2: " + isGreaterOrEqual);
            Console.WriteLine("item1 <= item2: " + isLessOrEqual);

            // Подсчет общего веса товаров по операторам + и -
            double totalWeight1 = item1 + item2;
            double totalWeight2 = item1 - item2;

            Console.WriteLine("Общий вес товаров 1 и 2: " + totalWeight1);
            Console.WriteLine("Разница веса товаров 1 и 2: " + totalWeight2);
        }
    }
}
