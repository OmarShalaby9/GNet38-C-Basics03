using System;
using System.Collections.Generic;
using System.Text;

namespace GNet38_C_Basics03
{
    internal class ReplaceArrays
    {
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
    }
}
