using System;

namespace AbstractTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Name = "Tobby";
            Console.WriteLine(dog.GetName());
            dog.Eat();
            
        }
    }
}
