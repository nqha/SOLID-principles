// See https://aka.ms/new-console-template for more information
using Single_Responsibility_Priciple.Class;

Console.WriteLine("Liskov Substitution principle: if a new class needs to be created, then it should not inherit the NO NEED method" +
    "in the parent class. Instead, we will create a new interface to define actions for the new class");

// Cleaner only implement method Working
CleanerStaff cleanerStaff = new CleanerStaff();
cleanerStaff.Working();
Console.WriteLine("-------------------------");

// But Developer implement TWO method: Working() and CheckAttendance()
Developer developer = new Developer();
developer.Working();
developer.CheckAttendance();

Console.ReadLine();