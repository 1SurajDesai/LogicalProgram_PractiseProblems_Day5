using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PerfectNo
    {
        public static void FindPerfectNo()
        {
            int num, sum, mn, mx;
            Console.WriteLine("Finding perfect numbers in given series");
            Console.WriteLine("Enter starting range:");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending range:");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect numbers are:");

            for (num = mn; num <= mx; num++)
            {
                int i = 1;
                sum = 0;
                while (i <= num/2)
                {
                    if (num % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == num)
                    Console.Write(num + " ");
            }
        }
    }
}
