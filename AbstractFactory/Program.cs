using AbstractFactory.Abstract;
using AbstractFactory.Concrete.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld world;

            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
