using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:\\Users\\20178670\\Desktop\\LoremIpsum.txt");
            String LoremIpsum = reader.ReadToEnd();

            char[] seperators = new char[] {' ', ',', '.' };
            string[] wordArr = LoremIpsum.Split(seperators);

            for (int i = 0; i < wordArr.Length; i++)
            {
                Console.WriteLine("Word number {0} is {1}",(i+1), wordArr [i]);
            }
            Console.ReadLine();
            reader.Close();
        }
    }
}
