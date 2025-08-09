using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator
{
    public class CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual string Description()
        {
            return coffee.Description();
        }      

        public virtual int Cost()
        {
            return coffee.Cost();
        }

    }
}