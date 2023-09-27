using SOLID_Principles.Single_responsibility_priciple;

namespace Single_Responsibility_Priciple.Class
{
    public class Developer : IEmployee, IFullTimeEmployee //IFullTimeEmployee will be created to adapt the new method: CheckAttendance
    {
        public void Working()
        {
            Console.WriteLine("The Developer is coding some function");
        }

        public void CheckAttendance()
        {
            Console.WriteLine("Check if the Developer is PTO today...");
        }
    }
}
