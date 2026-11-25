using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNet38_C_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Q2
            // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { 
            //    { 3, 5 }, 
            //    { 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            //PrintWelcomMassage.PrintWelcomeMessage();
            #endregion

            #region Q4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".
            //PrintBookTitles.PrintBookTitle("Clean Code");
            #endregion

            #region Q5
            //Write a method AddBonusPages(int pages) that adds 50 to pages.
            //Call it with a variable int pages = 400; and print pages afterward.
            //What do you expect to see, and why?
            //int pages = 400;
            //AddBounsPages.AddBonusPages(pages);
            //Console.WriteLine(pages);
            // i expect to see 400 because when we call the method it creates a copy of the original variable and work on it without affecting the original variable
            // and after the method is done it deletes the copy and returns to the original variable which is still 400
            #endregion

            #region Q6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscounts.ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // i expected 20.5 because when we call the method this time the method worked with the reference of the original array not a copy
            // so when the method executed it chaneged the value of the array element to 20.5 and save it in the original array and when we printed it we got 20.5
            #endregion

            #region Q7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            int pages = 400;
            AddBounsPages.AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            // because this time we used the reference of the original variable not a copy,
            // so when the method executed the changes were applied to the orginal variable and printed 450.
            #endregion
        }
    }
}
