using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
                Console.WriteLine("Enter a number:");
                int range = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                int n = random.Next(0, range);

                Console.Write("Enter the guessed number: ");
                while (true)
                {
                   int result;
                   string enter = Convert.ToString(Console.ReadLine());
                   if(int.TryParse(enter, out result))
                   {
                     if (result == n)
                     {
                         Console.Write("You guessed the number: " + n);
                         break;
                     }
                     else if (result > n) Console.Write("Your number is bigger: ");
                     else if (result < n) Console.Write("your number is less: ");
                   }
                   else if (string.IsNullOrEmpty(enter))
                   {
                       Console.WriteLine("Thanks for try");
                       Console.WriteLine("the hidden number" + n);
                       break;
                   }


            }
                Console.ReadKey();
            
        }
    }
}
