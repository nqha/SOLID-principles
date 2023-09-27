// See https://aka.ms/new-console-template for more information
using Dependency_Inversion_Principle.Interface;
using Dependency_Inversion_Principle.Services;
using Open_Close_Principle.Services;

Console.WriteLine("Dependency Inversion Principle: try to make a 'Loose Coupling' of each related Classes");

IConnectionManager connectionManager = new ConnectionManager();
LoginBL loginBL = new LoginBL(connectionManager);
loginBL.Login();

Console.ReadLine();