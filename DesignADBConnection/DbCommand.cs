using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignADBConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException("You can not use a null connection");
            if (instruction.Length <= 0 || instruction == null)
            {
                throw new Exception("You can not pass a null or empty instruction string.");
            }
            else
                _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
