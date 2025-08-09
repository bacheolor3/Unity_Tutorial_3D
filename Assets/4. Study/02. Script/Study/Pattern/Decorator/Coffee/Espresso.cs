using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator
{
    public class Espresso : ICoffee
    {
        public string Description()
        {
            return "Espresso";
        }
        public int Cost()
        {
            return 4000;
        }

    }

}