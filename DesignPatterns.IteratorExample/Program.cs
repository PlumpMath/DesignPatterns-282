using System;

namespace DesignPatterns.IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersAsc = new SortedNumbersList(SortedNumbersListType.Ascending);

            numbersAsc.Add(5);
            numbersAsc.Add(10);
            numbersAsc.Add(7);

            Console.WriteLine("PRINTING NUMBERS ASCENDING\n==========================");
            foreach (var number in numbersAsc)
            {
                Console.WriteLine(number);
            }

            var numbersDesc = new SortedNumbersList(SortedNumbersListType.Descending);

            numbersDesc.Add(1);
            numbersDesc.Add(4);
            numbersDesc.Add(100);

            Console.WriteLine("\nPRINTING NUMBERS DESCENDING\n===========================");
            foreach (var number in numbersDesc)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
