using Open_Close_Principle.Interface;

namespace Open_Close_Principle.ConnectionType
{
    public class SQLServer : IConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("Connecting to SQL Server Database...");
        }
    }
}
