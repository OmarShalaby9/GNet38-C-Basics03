using System;
using System.Collections.Generic;
using System.Text;

namespace GNet38_C_Basics03
{
    internal class PrintAllTitels
    {
        public static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
