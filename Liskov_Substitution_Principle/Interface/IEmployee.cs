namespace SOLID_Principles.Single_responsibility_priciple
{
    public interface IEmployee
    {
        public void Working();

        //void CheckAttendance(); --> should not place here because it violates "L" in SOLID principles
    }
}
