﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("--------------------");
            Console.WriteLine("\nGeben Sie die zu sumierenden Ganzzahlen mit Komma getrennt ein:");

            string input = Console.ReadLine();
            string[] input2 = input.Split(',');
            int[] zahl = new int[input2.Length];
            int[] ergebnis = new int[input2.Length];    //test
            int sum = 0;

            SumUp(zahl, input2);
            
            Console.WriteLine(string.Join(", " + ergebnis));
            Console.ReadKey();
        }
        static int[] SumUp(int[] zahl, string[] input2)
        {
            int[] ergebnis = new int[input2.Length];
            int sum = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                sum += zahl[i];
                ergebnis[i] = sum;
            }
            return ergebnis;
        }
    }
}