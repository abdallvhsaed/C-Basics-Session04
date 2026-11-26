using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies =
             {
                {3,5},
                {1,4}
             };
            Console.WriteLine(shelfCopies[1, 0]);

            #endregion
        }
    }
}
