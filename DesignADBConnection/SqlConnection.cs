using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignADBConnection
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"You have closed your connection to the SqlDB: {ConnectionString}");
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"You have opened a connection to the SqlDB: {ConnectionString}");
        }
    }
}
