using Dependency_Inversion_Principle.Interface;
using Open_Close_Principle.ConnectionType;
using Open_Close_Principle.Interface;

namespace Dependency_Inversion_Principle.Services
{
    public class LoginBL
    {
        // private variables
        private readonly IConnectionManager _connectionManager;

        // Init method
        public LoginBL(IConnectionManager connectionManager) {
            _connectionManager = connectionManager;
        }

        public void Login()
        {
            Console.WriteLine("1. Connect to DB");
            ConnectToDB();

            Console.WriteLine("2. Get login acc from DB");
            GetLoginAccount();

            Console.WriteLine("3. Save user logged in to Session");
            SaveSession();
        }

        //1. Connect to DB
        private void ConnectToDB()
        {
            Console.Write("Choose the type of Connection (1 for SQL server; 2 for PosgreSQL; 3 for Oracle): ");
            var connectType = Console.ReadLine();
            IConnection connection = null;
            switch (connectType)
            {
                case "1":
                    connection = new SQLServer();
                    break;
                case "2":
                    connection = new PosgreSQL();
                    break;
                case "3":
                    connection = new Oracle();
                    break;
                default:
                    break;
            }

            if (connection != null)
            {
                _connectionManager.DoConnection(connection);
            }
            else
            {
                Console.WriteLine("Cannot connect to the DB!");
            }
        }
        
        //2. Get login acc from DB
        private void GetLoginAccount() { }

        //3. Save user logged in to Session
        private void SaveSession() { }
    }
}
