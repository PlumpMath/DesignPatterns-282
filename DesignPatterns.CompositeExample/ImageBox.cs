using System;

namespace DesignPatterns.CompositeExample
{
    public class ImageBox : ILayoutElement
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Text { get; set; }

        public ImageBox(int x, int y, string text)
        {
            X = x;
            Y = y;
            Text = text;
        }

        public void Draw()
        {
            Console.WriteLine("ImageBox - X: {0} Y: {1} Text: {2}", X, Y, Text);
        }
    }
}
