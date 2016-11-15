using System;

namespace DesignPatterns.TemplateMethodExample
{
    public class RestRequestProcessor : RequestProcessor
    {
        protected override void GetBody()
        {
            Console.WriteLine("Getting Rest Body");
        }

        protected override void GetHeaders()
        {
            Console.WriteLine("Getting Rest Headers");
        }
    }
}
