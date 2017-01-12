using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        { string W = ("Welcome to my program ");
        string Y = (" ");
            System.Console.WriteLine("What is your first name?");
            Console.WriteLine();
            string F = Console.ReadLine();
            System.Console.WriteLine("What is your Surname?");
            Console.WriteLine();
            string S = Console.ReadLine();
            string O = (W + F + Y + S);
            System.Console.WriteLine(O);
                Console.Read();
        }
    }
}
