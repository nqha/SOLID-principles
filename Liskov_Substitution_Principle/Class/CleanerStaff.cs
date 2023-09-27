using SOLID_Principles.Single_responsibility_priciple;

namespace Single_Responsibility_Priciple.Class
{
    public class CleanerStaff: IEmployee //Cleaner staff just implement IEmployee as a normal worker that all employee will do (Working)
    {
        public void Working()
        {
            Console.WriteLine("The Cleaner is cleaning the floors...");
        }
    }
}
