using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemos
{
    class PrimeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 2,sum=0;
            while(n!=0)
            {
                if(n%k==0)
                {
                    sum++;
                }
                k++;
            }
            if (sum == 0)
                Console.WriteLine("Given number is prime");
            else
                Console.WriteLine("Given number is not prime");
            Console.ReadLine();
        }
    }
}
