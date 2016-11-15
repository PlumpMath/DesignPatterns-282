using System;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.AbstractFactoryExample
{
    public class SqlServerDatabase : IDatabase
    {
        IDbCommand _command;
        IDbConnection _connection;

        public IDbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = Connection;
                }

                return _command;
            }

            set
            {
                _command = value;
            }
        }

        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    var connectionString = "";
                    _connection = new SqlConnection(connectionString);
                }

                return _connection;
            }

            set
            {
                _connection = value;
            }
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Server database");
        }
    }
}
