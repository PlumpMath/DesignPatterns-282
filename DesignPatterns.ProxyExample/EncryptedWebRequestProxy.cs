using System;

namespace DesignPatterns.ProxyExample
{
    public class EncryptedWebRequestProxy : IRequest
    {
        IRequest _request;

        public EncryptedWebRequestProxy()
        {
            _request = new WebRequest();
        }

        public void MakeRequest()
        {
            Console.WriteLine("Encrypting web request PROXY");
            _request.MakeRequest();
            Console.WriteLine("Logging web request PROXY");
        }
    }
}
