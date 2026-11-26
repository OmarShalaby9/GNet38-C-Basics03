using System;
using System.Collections.Generic;
using System.Text;

namespace GNet38_C_Basics03
{
    internal class PrintBookInfos
    {
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book title: {title}, Pages: {pages}");
        }
    }
}
