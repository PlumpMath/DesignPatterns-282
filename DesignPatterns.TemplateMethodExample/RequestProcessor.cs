using System;

namespace DesignPatterns.TemplateMethodExample
{
    public abstract class RequestProcessor
    {
        protected abstract void GetHeaders();

        protected abstract void GetBody();

        public void ProcessRequest()
        {
            Console.WriteLine("Begin Processing request");

            GetHeaders();
            GetBody();

            Console.WriteLine("End Processing request");
        }
    }
}
