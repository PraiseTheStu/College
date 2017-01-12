using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                int highest = array1.Max();
                Console.WriteLine(highest);
                Console.ReadLine();
        }
    }
}
