﻿using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(),
                new Latte(),
                new Black_Coffee()

            };

            List<IMilk> coffeMilk = new List<IMilk>()
            {
                new Cortado(),
                new Latte()
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price() + " The strenght of the cofee is: "+ coffee.Strength() );
            }
            Console.ReadKey();

        }
    }
}
