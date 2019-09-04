using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Black_Coffee: Coffee
    {
        public override string Strength()
        {
            return "Strong";
        }

        public Black_Coffee()
        {
            Discount = 15;
        }

    }
}
