using System;

namespace DesignPatterns.DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello world!\nHow are you today?";

            var letter = new Letter(text);

            Console.WriteLine(letter.GetBody());

            var capitalizedLetter = new CapitalizedDocument(new Letter(text));

            Console.WriteLine(capitalizedLetter.GetBody());

            var doubleSpacedCapitalizedLetter = new DoubleSpacedDocument(new CapitalizedDocument(new Letter(text)));

            Console.WriteLine(doubleSpacedCapitalizedLetter.GetBody());

            Console.ReadLine();
        }
    }
}
