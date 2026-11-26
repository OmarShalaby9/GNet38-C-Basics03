using System;
using System.Collections.Generic;
using System.Text;

namespace GNet38_C_Basics03
{
    internal class TryGetPrices
    {
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
    }
}
