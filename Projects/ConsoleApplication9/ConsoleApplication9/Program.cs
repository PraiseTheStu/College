using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a value");
                numbers[i] = int.Parse(Console.ReadLine());




            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];

                }
            }

            Console.WriteLine("The highest value is " + max);
            Console.ReadLine();
        }
    }
}
