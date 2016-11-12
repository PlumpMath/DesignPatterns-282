using System.Data;
using MySql.Data.MySqlClient;

namespace DesignPatterns.FactoryMethodExample
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
    }
}
