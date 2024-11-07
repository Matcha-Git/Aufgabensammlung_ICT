using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib deinen Namen ein:");

            string vorname = Console.ReadLine();

            Console.WriteLine("Hello " + vorname);

            Console.ReadKey();

        }

        static string test()
        {
            string intake;

            Console.Write("Tell me what to say:\t");
            intake = Console.ReadLine();

            Console.WriteLine($"\n\"{intake}\"");

            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}
