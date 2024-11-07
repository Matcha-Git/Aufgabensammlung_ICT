using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            string input;

            string[] monat = new string[12];
            monat[0] = "Januar";
            monat[1] = "Februar";
            monat[2] = "März";
            monat[3] = "April";
            monat[4] = "Mai";
            monat[5] = "Juni";
            monat[6] = "Juli";
            monat[7] = "August";
            monat[8] = "September";
            monat[9] = "Oktober";
            monat[10] = "November";
            monat[11] = "Dezember";

            Console.Write("Geben Sie eine Zahl zwischen 1 und 12 an:\t");
            input = Console.ReadLine();

            if (int.TryParse(input, out zahl) == true)
            {
                switch (zahl)
                {
                    case 0:
                        Console.WriteLine("ERROR");
                        break;
                    case 1:
                        Console.WriteLine($"Monat:\t{monat[0]}");
                        break;
                    case 2:
                        Console.WriteLine($"Monat:\t{monat[1]}");
                        break;
                    case 3:
                        Console.WriteLine($"Monat:\t{monat[2]}");
                        break;
                    case 4:
                        Console.WriteLine($"Monat:\t{monat[3]}");
                        break;
                    case 5:
                        Console.WriteLine($"Monat:\t{monat[4]}");
                        break;
                    case 6:
                        Console.WriteLine($"Monat:\t{monat[5]}");
                        break;
                    case 7:
                        Console.WriteLine($"Monat:\t{monat[6]}");
                        break;
                    case 8:
                        Console.WriteLine($"Monat:\t{monat[7]}");
                        break;
                    case 9:
                        Console.WriteLine($"Monat:\t{monat[8]}");
                        break;
                    case 10:
                        Console.WriteLine($"Monat:\t{monat[9]}");
                        break;
                    case 11:
                        Console.WriteLine($"Monat:\t{monat[10]}");
                        break;
                    case 12:
                        Console.WriteLine($"Monat:\t{monat[11]}");
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            
            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}
