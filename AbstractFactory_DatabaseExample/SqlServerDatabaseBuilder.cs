using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public class SqlServerDatabaseBuilder : IDatabaseBuilder
    {
        IDatabase _database;

        public IDatabase Database
        {
            get { return _database; }
        }

        public string CommandText { get; }

        public SqlServerDatabaseBuilder(string commandText)
        {
            _database = new SqlServerDatabase();
            CommandText = commandText;
        }

        public void BuildCommand()
        {
            _database.Command = new SqlCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void BuildConnection()
        {
            var connectionString = "";
            _database.Connection = new SqlConnection(connectionString);
        }

        public void SetSettings()
        {
            _database.Command.CommandTimeout = 360;
            _database.Command.CommandType = CommandType.Text;
            _database.Command.CommandText = CommandText;
        }
    }
}
