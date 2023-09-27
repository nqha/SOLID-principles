using Open_Close_Principle.Interface;

namespace Open_Close_Principle.ConnectionType
{
    public class PosgreSQL : IConnection
    {
        public void DoConnect()
        {
            Console.WriteLine("Connecting to PosgreSQL Database...");
        }
    }
}
