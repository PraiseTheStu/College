using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "abcdefghijklmnopqrstuvwxyz";
            char[] c = A.ToArray();
            Console.WriteLine("message = {0}", A);
            Console.WriteLine("message.Length = {0}", A.Length);
            Console.ReadLine();
            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");
            Console.WriteLine(index);
            string book = "Hello,";
            int index = book.IndexOf("C#");
            Console.WriteLine(index);
            }
        }
    }
