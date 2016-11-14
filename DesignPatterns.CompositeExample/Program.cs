using System;

namespace DesignPatterns.CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var layout = new CompositeLayout();

            layout.Add(new TextBox(200, 200, "Hello TextBox World!"));
            layout.Add(new ImageBox(400, 400, "Hello ImageBox World!"));

            layout.Draw();

            Console.ReadLine();
        }
    }
}
