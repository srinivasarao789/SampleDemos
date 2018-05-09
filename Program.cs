using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter string");
            string str, revstr =" ";
            str = Console.ReadLine();
            for(int i=str.Length-1;i>=0; i--)
            {
                revstr = revstr + str[i];
            }
            Console.WriteLine("reverse string is" + revstr);
            Console.ReadLine();
        }
    }
}
