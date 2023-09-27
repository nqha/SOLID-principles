// See https://aka.ms/new-console-template for more information
using Interface_Segregation_Principle.Class;

Console.WriteLine("Interface Segregation Principle: split an Interface to multible Interfaces to adapt actions of each implemented Classes");

Cat cat = new Cat();
Eagle eagle = new Eagle();

Console.WriteLine("Call Eat() method for all implemented classes");
cat.Eat();
eagle.Eat();

Console.WriteLine("Call Run() method in Cat");
cat.Run();
Console.WriteLine("Call Fly() method in Eagle");
eagle.Fly();

Console.ReadLine();