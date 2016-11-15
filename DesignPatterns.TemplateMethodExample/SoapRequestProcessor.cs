using System;

namespace DesignPatterns.TemplateMethodExample
{
    public class SoapRequestProcessor : RequestProcessor
    {
        protected override void GetBody()
        {
            Console.WriteLine("Getting Soap Body");
        }

        protected override void GetHeaders()
        {
            Console.WriteLine("Getting Soap Headers");
        }
    }
}
