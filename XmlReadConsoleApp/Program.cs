using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XmlReadConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            StreamReader xmlFile = new StreamReader("c:\\XML\\apdev-examples.xml");

            while ((line = xmlFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            xmlFile.Close();
            Console.ReadLine();
        }
    }
}
