using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator
{
    public class MochaDecorator : CoffeeDecorator
    {
        public MochaDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string Description()
        {
            return coffee.Description() + "Mocha";
        }

        public override int Cost()
        {
            return coffee.Cost() + 1000;
        }
    }
}