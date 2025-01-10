using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szamokKioszt
{
    class Program
    {
        static void Main()
        {
            // A fájl elérési útja
            string filePath = "similar_file.txt";

            //a fájl létezik-e
            if (File.Exists(filePath))
            {
                // Fájl beolvasása
                string fileContent = File.ReadAllText(filePath);

                // A fájl tartalmának megjelenítése a konzolon
                Console.WriteLine("A fájl tartalma:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("A fájl nem található.");
            }

            
            Console.ReadLine();
        }
    }
}
