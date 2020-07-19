/* Programmer: Austin Parker
 * Date: Jan. 10th, 2020
 * Purpose: This class is used to send one statement, 
 * three different ways to the output screen. 
 */
using System;
using static System.Console;

namespace Chapter1_Saying
{
    class Saying
    {
        static void Main()
        {
            //This will set the background to white and the text to black. 
            BackgroundColor = ConsoleColor.White;
            Clear();
            ForegroundColor = ConsoleColor.Black;

            //This will display phrase on one line only.
            Write(" Output #1\n\tNo one can ");
            Write("make you feel inferior ");
            Write("without your consent.\n");

            //This will display phrase on three seperate lines. 
            Write("\n Output #2\n\tNo one can \n");
            Write("\tmake you feel inferior \n");
            Write("\twithout your consent.\n");

            //This will display each word of phrase on seperate lines. 
            WriteLine("\n Output #3\n\tNo\n\tone\n\tcan\n\tmake\n\tyou\n\tfeel\n\tinferior\n\twithout\n\tyour\n\tconsent.");

            ReadKey();
        }
    }
}
