using SOLID_Principles.Single_responsibility_priciple;

namespace Single_Responsibility_Priciple.Class
{
    public class Salesman : IEmployee, IFullTimeEmployee
    {
        public void Working()
        {
            Console.WriteLine("The Salesman is seling the sofware application");
        }

        public void CheckAttendance()
        {
            Console.WriteLine("Check if the Salesman is PTO today...");
        }
    }
}
