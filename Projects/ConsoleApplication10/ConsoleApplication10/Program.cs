using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] intArray = new int[10] { 1, 3, 2, 5, 4, 7, 6, 9, 8, 10};
            Array.Sort(intArray);
            
            foreach (int i in intArray) Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
