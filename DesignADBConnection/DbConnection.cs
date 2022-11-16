public abstract class DbConnection
{
    public String ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }

    public DbConnection(string connectionString)
    {
        if (connectionString.Length <= 0 || connectionString == null)
        {
            throw new Exception("You can not pass a null or empty connection string.");
        }
        else
            ConnectionString = connectionString;
    }

    public abstract void OpenConnection();

    public abstract void CloseConnection();
}