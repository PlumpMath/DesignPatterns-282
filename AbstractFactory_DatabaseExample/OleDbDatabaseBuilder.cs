using System;
using System.Data;
using System.Data.OleDb;

namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public class OleDbDatabaseBuilder : IDatabaseBuilder
    {
        IDatabase _database;

        public IDatabase Database
        {
            get { return _database; }
        }

        public string CommandText { get; }

        public OleDbDatabaseBuilder(string commandText)
        {
            _database = new OleDbDatabase();
            CommandText = CommandText;
        }

        public void BuildCommand()
        {
            _database.Command = new OleDbCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void BuildConnection()
        {
            var connectionString = "";
            _database.Connection = new OleDbConnection(connectionString);
        }

        public void SetSettings()
        {
            _database.Command.CommandTimeout = 360;
            _database.Command.CommandType = CommandType.Text;
            _database.Command.CommandText = CommandText;
        }
    }
}
