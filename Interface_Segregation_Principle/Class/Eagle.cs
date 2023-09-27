using Interface_Segregation_Principle.Interface;

namespace Interface_Segregation_Principle.Class
{
    public class Eagle: IFlyableAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Eagle is eating...");
        }

        public void Fly()
        {
            Console.WriteLine("The Eagle is flying...");
        }
    }
}
