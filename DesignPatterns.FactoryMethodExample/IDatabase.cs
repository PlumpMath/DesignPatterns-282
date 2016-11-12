using System.Data;

namespace DesignPatterns.FactoryMethodExample
{
    public interface IDatabase
    {
        IDbCommand Command { get; set; }
        IDbConnection Connection { get; set; }
    }
}
