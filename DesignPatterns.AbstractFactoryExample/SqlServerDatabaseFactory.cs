namespace DesignPatterns.AbstractFactoryExample
{
    public class SqlServerDatabaseFactory : IDatabaseFactory
    {
        public IDatabase CreateDatabase()
        {
            return new SqlServerDatabase();
        }
    }
}
