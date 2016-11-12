namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public interface IDatabaseBuilder
    {
        IDatabase Database { get; }

        string CommandText { get; }

        void BuildConnection();

        void BuildCommand();

        void SetSettings();
    }
}
