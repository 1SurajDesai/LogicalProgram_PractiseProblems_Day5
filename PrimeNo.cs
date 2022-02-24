using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNo
    {
        public static void CheckPrimeNo()
        {
            int flag = 0;
            int num;
            Console.WriteLine("Enter a no:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("Not a Prime number");
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        Console.WriteLine("Not a Prime number");
                        break;
                    }

                }
                if (flag == 0)
                    Console.WriteLine("Prime number");
            }
        }
    }
}
