using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            // Console.WriteLine(Array1[5]);
            // Console.ReadLine();
            int[] Array1 = new int[10];

            for (int i = 0; i < Array1.Length; i++)
            {

                Console.WriteLine("Enter a value");
                Array1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
            }
        }
    }
}
    
