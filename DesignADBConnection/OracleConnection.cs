using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignADBConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"You have closed your connection to the OracleDB: {ConnectionString}");
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"You have opened a connection to the OracleDB: {ConnectionString}");
        }
    }
}
