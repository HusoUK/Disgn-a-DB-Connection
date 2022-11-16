using DesignADBConnection;

Console.WriteLine("Hello, World!");

var newSqlConnection = new SqlConnection("DbMyFakedb/localhost:1010");

newSqlConnection.OpenConnection();
newSqlConnection.CloseConnection();

Console.WriteLine("----------------\n----------------");


var newOracleConnection = new OracleConnection("DbMyFakedb/localhost:2020");

newOracleConnection.OpenConnection();
newOracleConnection.CloseConnection();

Console.WriteLine("----------------\n----------------");

var newDbCommand = new DbCommand(newSqlConnection, "Testing 1,2,3.");
newDbCommand.Execute();

Console.WriteLine("----------------\n----------------");

var newerDbCommand = new DbCommand(newOracleConnection, "Testing 4,5,6.");
newerDbCommand.Execute();
