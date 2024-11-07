using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            bool foundForbiddenWord = false;

            Console.WriteLine("Text:");

            string antwort = Console.ReadLine().ToLower();

            for (int i = 0; i < forbiddenWords.Length; i++)
            {

                if (antwort.Contains(forbiddenWords[i]))
                {

                    foundForbiddenWord = true;

                }


            }
            if (foundForbiddenWord == true)
            {
                Console.WriteLine("Es wurden verbotene Wörter gefunden");
            }
            else
            {
                Console.WriteLine("Es wurden keine verbotenen Wörter gefunden");
            }

            Console.ReadKey();

        }
    }
}