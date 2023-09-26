using Open_Close_Principle.Interface;

namespace Open_Close_Principle.Services
{
    public class ConnectionManager
    {
        public void DoConnection(IConnection connection)
        {
            connection.DoConnect();
        }
    }
}
