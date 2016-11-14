using System;

namespace DesignPatterns.CompositeExample
{
    public class TextBox : ILayoutElement
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Text { get; set; }

        public TextBox(int x, int y, string text)
        {
            X = x;
            Y = y;
            Text = text;
        }

        public void Draw()
        {
            Console.WriteLine("TextBox - X: {0} Y: {1} Text: {2}", X, Y, Text);
        }
    }
}
