using System;

namespace DesignPatterns.ProxyExample
{
    public class WebRequest : IRequest
    {
        public void MakeRequest()
        {
            Console.WriteLine("Making web request");
        }
    }
}
