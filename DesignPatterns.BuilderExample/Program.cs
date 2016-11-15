using System;

namespace DesignPatterns.BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new RequestBuildDirector();
            var requestOne = director.Construct("http://requestbuilddirector.com", "requestbuilddirector", "testpassword1", "REQUEST BUILD DIRECTOR");

            Console.WriteLine(requestOne.Print());

            var requestTwo = new RequestBuilder()
                .SetUrl("http://requestbuilderfluent.com")
                .AddHeader("username", "requestbuilderfluent")
                .AddHeader("password", "testpassword2")
                .SetBody("REQUEST BUILDER FLUENT")
                .Build();

            Console.WriteLine(requestTwo.Print());

            Console.ReadLine();
        }
    }
}
