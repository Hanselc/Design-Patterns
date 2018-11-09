using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Concrete.Products;

namespace AbstractFactory.Concrete.Factories
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
