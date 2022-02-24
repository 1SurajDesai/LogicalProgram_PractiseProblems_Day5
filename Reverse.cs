using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class Reverse
    {
        public static void ReverseNum()
        {
            int n, rem, reverse = 0;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Revrsed number is " + reverse);
        }
    }
    
}
