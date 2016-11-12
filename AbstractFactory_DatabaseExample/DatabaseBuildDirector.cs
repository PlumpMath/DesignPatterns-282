namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public class DatabaseBuildDirector
    {
        public IDatabase Build(IDatabaseBuilder builder)
        {
            builder.BuildConnection();
            builder.BuildCommand();
            builder.SetSettings();

            return builder.Database;
        }
    }
}
