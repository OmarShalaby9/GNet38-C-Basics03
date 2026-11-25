using System;
using System.Collections.Generic;
using System.Text;

namespace GNet38_C_Basics03
{
    internal class AddBounsPages
    {
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
    }
}
