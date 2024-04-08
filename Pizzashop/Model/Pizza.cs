using System;
using System.Collections.Generic;

namespace Pizzashop.Model
{
    public class Pizza
    {
        public enum Size
        {
            Small,
            Medium,
            Large
        }

        private Dictionary<string, int> toppingPrices = new Dictionary<string, int>()
        {
            { "Mushrooms", 20 }, { "Black olives", 21 }, { "Pepperoni", 22 }, { "Chicken", 23 },
            { "Pineapple", 24 }, { "Spinach", 25 }, { "Tomatoes", 26 }, { "Cheese", 27 },
            { "Onions", 28 }, { "Sausage", 29 }, { "Artichokes", 30 }, { "Bacon", 21 },
            { "Bell pepper", 22 }, { "Anchovies", 23 }, { "Peppers", 24 }, { "Prosciutto", 25 },
            { "Basil", 26 }, { "Beef", 27 }
        };

        private Dictionary<Size, int> sizePrices = new Dictionary<Size, int>()
        {
            { Size.Small, 100 }, { Size.Medium, 150 }, { Size.Large, 200 }
        };

        public Size PizzaSize { get; }
        public List<string> Toppings { get; }

        public Pizza(Size size, List<string> toppings)
        {
            PizzaSize = size;

            Toppings = toppings;
        }

     

        public int CalculatePrice()
        {
            int totalPrice = sizePrices[PizzaSize];

            foreach (string topping in Toppings)
            {
                if (toppingPrices.ContainsKey(topping))
                {
                    totalPrice += toppingPrices[topping];
                }
            }

            return totalPrice;
        }
    }
}
