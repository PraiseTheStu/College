using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int[] Array1 = new int[10];

            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("Enter a value");
                Array1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
                Console.WriteLine("[{0}]", string.Join(", ", Array1));
                total = i;
            }
        }

    }
}
