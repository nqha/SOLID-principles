using Interface_Segregation_Principle.Interface;

namespace Interface_Segregation_Principle.Class
{
    public class Cat: IRunnableAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Cat is eating...");
        }

        public void Run()
        {
            Console.WriteLine("The Cat is running...");
        }
    }
}
