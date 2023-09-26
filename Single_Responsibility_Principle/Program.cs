// Sigle responsibility principle
// Each class is doing a specific function
using Single_Responsibility_Priciple.Class;

Developer developer = new Developer();
Tester tester = new Tester();
Salesman salesman = new Salesman();

developer.Working();
tester.Working();
salesman.Working();

Console.ReadLine();