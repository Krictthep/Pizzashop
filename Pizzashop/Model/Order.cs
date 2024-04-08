using System;
using System.Collections.Generic;

namespace Pizzashop.Model
{
    public class Order
    {
        private List<Pizza> pizzas = new List<Pizza>();
        private const int motorbikeDeliveryFee = 50;
        private const int carDeliveryFee = 100;

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public int CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (Pizza pizza in pizzas)
            {
                totalPrice += pizza.CalculatePrice();
            }

            if (pizzas.Count <= 2)
            {
                totalPrice += motorbikeDeliveryFee;
            }
            else
            {
                totalPrice += carDeliveryFee;
            }

            return totalPrice;
        }


        public int CalculateCountPizza()
        {
            int countPizza = 0;

            foreach (Pizza pizza in pizzas)
            {
                countPizza++;
            }
            return countPizza;
        }
    }
}
