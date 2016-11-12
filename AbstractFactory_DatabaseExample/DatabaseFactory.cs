namespace DesignPatterns.AbstractFactory_DatabaseExample
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
                case DatabaseType.OleDb:
                    return new OleDbDatabase();                
            }

            return database;
        }
    }
}
