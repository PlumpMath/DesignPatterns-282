using System.Data;

namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public interface IDatabase
    {
        IDbCommand Command { get; set; }
        IDbConnection Connection { get; set; }
    }
}
