using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAPTER_01_Welcome_to_CSharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ronak Sankhala");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.DaysInMonth(2020,1));
            Console.Read();

        }
    }
}
