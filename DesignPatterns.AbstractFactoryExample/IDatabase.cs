using System.Data;

namespace DesignPatterns.AbstractFactoryExample
{
    public interface IDatabase
    {
        IDbCommand Command { get; set; }
        IDbConnection Connection { get; set; }

        void Connect();
    }
}
