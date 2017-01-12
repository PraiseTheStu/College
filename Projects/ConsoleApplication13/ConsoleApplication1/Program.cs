using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{

    public class FileReader
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("C:\\Users\\20178670\\Desktop\\LoremIpsum.txt");
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
            Console.ReadLine();
            reader.Close();
            StreamWriter writer = new StreamWriter("C:\\Users\\20178670\\Desktop\\LoremIpsum-Output.txt");
            string output = line;
            while (output != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                output = line;
            }
            writer.WriteLine();
            writer.Flush();
            writer.Close();

        }

    }
}
    





        
    
