using System;

namespace DesignPatterns.ProxyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestRegular = new WebRequest();
            var requestProxy = new EncryptedWebRequestProxy();

            requestRegular.MakeRequest();
            requestProxy.MakeRequest();

            Console.ReadLine();
        }
    }
}
