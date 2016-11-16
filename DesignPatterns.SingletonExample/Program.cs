using System;

namespace DesignPatterns.SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Host: \t\t{0}", FtpSettings.Instance.Host);
            Console.WriteLine("Port: \t\t{0}", FtpSettings.Instance.Port);
            Console.WriteLine("Username: \t{0}", FtpSettings.Instance.Username);
            Console.WriteLine("Password: \t{0}", FtpSettings.Instance.Password);

            Console.ReadLine();
        }
    }
}
