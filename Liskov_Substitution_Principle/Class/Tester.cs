using SOLID_Principles.Single_responsibility_priciple;

namespace Single_Responsibility_Priciple.Class
{
    public class Tester : IEmployee, IFullTimeEmployee
    {
        public void Working()
        {
            Console.WriteLine("The Tester is testing some function");
        }

        public void CheckAttendance()
        {
            Console.WriteLine("Check if the Tester is PTO today...");
        }
    }
}
