using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Concrete.Products;

namespace AbstractFactory.Concrete.Factories
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
