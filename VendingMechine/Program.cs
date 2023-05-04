using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMechine
{
    internal class Program
    {
        public static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        static void Main(string[] args)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        Console.Write("Enter the amount to be returned: ");
            int amount = int.Parse(Console.ReadLine());

            int[] count = new int[notes.Length];

            CalculateNotes(amount, count);

            int totalNotes = 0;

            Console.WriteLine("Notes to be returned:");

            for (int i = 0; i < notes.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} notes of Rs {1}", count[i], notes[i]);
                    totalNotes += count[i];
                }
            }

            Console.WriteLine("Total number of notes: {0}", totalNotes);
        }

        static void CalculateNotes(int amount, int[] count)
        {
            if (amount == 0)
            {
                return;
            }

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    count[i]++;
                    amount -= notes[i];
                    break;
                }
            }

            CalculateNotes(amount, count);
        }
    }
}
