// See https://aka.ms/new-console-template for more information
using Open_Close_Principle.ConnectionType;
using Open_Close_Principle.Services;

Console.WriteLine("Open/Close principle: should not edit an exist class, but can extend the function by create new class and inherit original class");

Console.Write("Choose the type of Connection (1 for SQL server; 2 for PosgreSQL; 3 for Oracle): ");
var connectType = Console.ReadLine();
ConnectionManager connectionManager = new ConnectionManager();

switch (connectType)
{
	case "1":
		connectionManager.DoConnection(new SQLServer());
		break;
	case "2":
		connectionManager.DoConnection(new PosgreSQL());
		break;
    case "3":
        connectionManager.DoConnection(new Oracle());
        break;
    // if it will has a new type of connection, just create new Class and inherit IConnection
    default:
		break;
}