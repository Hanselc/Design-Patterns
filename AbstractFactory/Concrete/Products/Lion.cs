using AbstractFactory.Abstract.Products;
using System;

namespace AbstractFactory.Concrete.Products
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
                " eats " + h.GetType().Name);
        }
    }
}
