using System;

namespace DesignPatterns.AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Adapter();

            var response = target.MakeRequest();

            Console.WriteLine("Success: {0}\nErrorMessage: {1}", response.Success, response.ErrorMessage);
            Console.ReadLine();
        }
    }
}
