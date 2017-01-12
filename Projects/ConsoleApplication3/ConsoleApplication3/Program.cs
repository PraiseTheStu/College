using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {     int A;
              int B;
              int C;
            

             Console.WriteLine("Please Enter the quiz score");
              A = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the mid-term score");
              B = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the final score");
              C = int.Parse(Console.ReadLine());
       
            int D = (A + B + C)/3;
           // int E = (D / 3);
           // Console.WriteLine(E);
            if (D > 90)
                Console.WriteLine("A");
            else
            Console.ReadLine();
        }
    }
}
  