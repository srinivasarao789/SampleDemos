using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemos
{
    class Pattern
    {
        static void Main()

        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)

                        Console.Write("*" + " ");
                    else
                        Console.Write(j + " ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
