using Dependency_Inversion_Principle.Interface;
using Open_Close_Principle.Interface;

namespace Open_Close_Principle.Services
{
    public class ConnectionManager: IConnectionManager
    {
        public void DoConnection(IConnection connection)
        {
            connection.DoConnect();
            Console.WriteLine("Connected to the DB!");
        }
    }
}
