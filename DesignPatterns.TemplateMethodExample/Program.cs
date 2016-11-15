using System;

namespace DesignPatterns.TemplateMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var soapRequest = new SoapRequestProcessor();
            var restRequest = new RestRequestProcessor();

            soapRequest.ProcessRequest();
            restRequest.ProcessRequest();

            Console.ReadLine();
        }
    }
}
