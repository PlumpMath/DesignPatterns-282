using System;

namespace DesignPatterns.AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory factory = null;
            var databaseType = DatabaseType.SqlServer;

            switch (databaseType)
            {
                case DatabaseType.SqlServer:
                    factory = new SqlServerDatabaseFactory();
                    break;
                case DatabaseType.MySql:
                    factory = new MySqlDatabaseFactory();
                    break;
            }

            if (factory != null)
            {
                var database = factory.CreateDatabase();

                database.Connect();
            }

            Console.ReadLine();
        }
    }
}
