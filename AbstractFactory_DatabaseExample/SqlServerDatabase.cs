using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.AbstractFactory_DatabaseExample
{
    public class SqlServerDatabase : IDatabase
    {
        IDbCommand _command;
        IDbConnection _connection;

        public IDbCommand Command
        {
            get
            {
                // lazy loading, don't create it until it's needed and don't re-create it once it's been created
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
                // lazy loading, don't create it until it's needed and don't re-create it once it's been created
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
    }
}
