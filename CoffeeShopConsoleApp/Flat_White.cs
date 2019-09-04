using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Flat_White: Coffee
    {
        public override string Strength()
        {
            return "Mild";
        }

        public override int price()
        {
            return 30;
        }
    }
}
