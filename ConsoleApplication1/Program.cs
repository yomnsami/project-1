using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, i, j;
            Console.WriteLine("Ent num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ent num2");
            num2 = int.Parse(Console.ReadLine());
            for (i = num1; i <= num2; i++)
            {
                sum = 0;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        sum++;
                        break;
                    }
                }
                if (sum == 0 && i != 1)
                    Console.WriteLine("{0}", i);


            }
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
