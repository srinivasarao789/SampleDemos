using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemos
{
    class Stirngreverse
    {
        static void Main()
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string s1 = string.Empty;
            for(int i=s.Length-1;i>=0;i--)
            {
                s1 = s1 + s[i];
            }
            Console.WriteLine(s1 + " ");
            Console.ReadLine();
        }
    }
}
