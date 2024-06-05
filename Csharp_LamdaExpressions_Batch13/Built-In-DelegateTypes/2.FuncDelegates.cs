using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncNamespace
{
    public class ShoppingCart
    {

        //90.89 67.90 56 , 89.00
        public List<double> ItemPrices { get; set; }

    }
    internal class FuncClass
    {
        public static void Main()
        {
            //i am taking the integer as output and return the data as output..
            Func<int, int> func1 = (int x) =>
            {
                return x + 10;
            };

            int result = func1(10); // 20;
            Console.WriteLine(result);


            Func<int> func2 = () =>
            {
                return 10;
            };
            func2(); //10


            Func<int, int, int> func3 = (int x, int y) =>
            {
                return x + y;
            };

            Func<int, int, int> func4 = (int x, int y) => x + y;

            func2(); //10

            ShoppingCart shoppingCart = new ShoppingCart();


            //Try to understand the data what we have.
            //Always do the practice together
            shoppingCart.ItemPrices.Add(10);
            shoppingCart.ItemPrices.Add(10.09);
            shoppingCart.ItemPrices.Add(20.09);
            shoppingCart.ItemPrices.Add(0.09);
            shoppingCart.ItemPrices.Add(50.09);
            shoppingCart.ItemPrices.Add(60.09);

            shoppingCart.ItemPrices.Sum(); //
            shoppingCart.ItemPrices.Average();

            //where item price is more than 15 rupees
            // 3 items
            var items = shoppingCart.ItemPrices.Where(itemPrice => itemPrice > 15);

            //(int x, int y) =>
            //{
            //    return x + y;
            //};
            var items1 = shoppingCart.ItemPrices.Where(itemPrice =>
                                                      {
                                                          return itemPrice > 15;
                                                      });

            foreach (var item in items)
            {
                Console.WriteLine($"item price is {item}");
            }


            //All items are more than 50 or not  All and Any
            bool isAllitemsMorethan50 = shoppingCart.ItemPrices.All(itemPrice => itemPrice > 50);
            Console.WriteLine(isAllitemsMorethan50); //false

            bool isAnyItemMorethan50 = shoppingCart.ItemPrices.Any(itemPrice => itemPrice > 50);
            Console.WriteLine(isAnyItemMorethan50);  //true

            //strong
            IEnumerable<double> items9 = shoppingCart.ItemPrices.Take(2);

            //anykind value it can accept
            var items10 = shoppingCart.ItemPrices.Take(2);

            //shoppingCart.ItemPrices.Single()


            //shoppingCart.ItemPrices.sel


            //var newItems = items.Select((item) => item + 10);

            //Select Join Single First

            //shoppingCart.ItemPrices.




        }
    }
}
