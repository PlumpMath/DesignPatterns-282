namespace DesignPatterns.AbstractFactoryExample
{
    public class MySqlDatabaseFactory : IDatabaseFactory
    {
        public IDatabase CreateDatabase()
        {
            return new MySqlDatabase();
        }
    }
}
