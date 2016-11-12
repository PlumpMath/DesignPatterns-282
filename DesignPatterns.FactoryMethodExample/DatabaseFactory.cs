namespace DesignPatterns.FactoryMethodExample
{
    public class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            IDatabase database = null;

            switch (dbType)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                case DatabaseType.MySql:
                    return new MySqlDatabase();
            }

            return database;
        }
    }
}
