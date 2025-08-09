using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string Description()
        {
            return coffee.Description() + "Milk";
        }

        public override int Cost()
        {
            return coffee.Cost() + 500;
        }
    }
}