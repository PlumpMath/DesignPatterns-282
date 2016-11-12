using System;
using System.Configuration;

namespace DesignPatterns.FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the databaseType from the app.config
            var databaseType = Convert.ToInt32(ConfigurationManager.AppSettings["DatabaseType"].ToString());
            var database = DatabaseFactory.CreateDatabase((DatabaseType)databaseType);

            Console.ReadLine();
        }
    }
}
