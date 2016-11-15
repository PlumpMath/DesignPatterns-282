using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace DesignPatterns.AbstractFactoryExample
{
    public class MySqlDatabase : IDatabase
    {
        IDbCommand _command;
        IDbConnection _connection;

        public IDbCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new MySqlCommand();
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
                    _connection = new MySqlConnection(connectionString);
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
            Console.WriteLine("Connecting to mySQL database");
        }
    }
}
