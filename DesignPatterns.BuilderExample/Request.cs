using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderExample
{
    public class Request
    {
        public string Url { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }

        public string Print()
        {
            var printBuilder = new StringBuilder();

            printBuilder.Append(string.Format("URL: {0}", Url));

            foreach (var header in Headers)
            {
                printBuilder.Append(string.Format("\nHeader: {0} : {1}", header.Key, header.Value));
            }

            printBuilder.Append(string.Format("\nBody: {0}\n", Body));

            return printBuilder.ToString();
        }
    }
}