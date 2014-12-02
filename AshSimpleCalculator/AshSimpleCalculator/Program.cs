// Simple Calculator  by Ashiwin, December 2014 //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC = System.Console;

namespace AshSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Calculator by Ashiwin";
            
            try
            {
                // Title //
                SC.WriteLine("Simple Calculator\nby Ashiwin");

                // Legend //
                SC.WriteLine("\nHow it works:\nx ? y = z\n\nLegend:\nx - value for x (integer or decimal)\ny - value for y (integer or decimal)\n? - operator\nz - result");

                // Value for x //
                SC.WriteLine("\nKey in a number for x (x):");
                decimal x = Convert.ToDecimal(SC.ReadLine());

                // Value for y //
                SC.WriteLine("\nKey in a number for y (y):");
                decimal y = Convert.ToDecimal(SC.ReadLine());

                // Operator //
                SC.WriteLine("\nChoose an operator (?):");
                SC.WriteLine("1 - addition");
                SC.WriteLine("2 - subtraction");
                SC.WriteLine("3 - multiplication");
                SC.WriteLine("4 - division");
                int z = Convert.ToInt32(SC.ReadLine());

                // Switch statement for calculation //
                SC.WriteLine("\nResult (z):");

                switch (z)
                {
                    case 1:
                        SC.WriteLine(x + y);
                        break;
                    case 2:
                        SC.WriteLine(x - y);
                        break;
                    case 3:
                        SC.WriteLine(x * y);
                        break;
                    case 4:
                        SC.WriteLine(x / y);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Invalid operator.");
                }
            }
            catch (Exception ex)
            {
                SC.WriteLine("\nError: " + ex.Message);
            }

            SC.WriteLine("\nPress any key to exit.");
            SC.ReadKey();
        }
    }
}