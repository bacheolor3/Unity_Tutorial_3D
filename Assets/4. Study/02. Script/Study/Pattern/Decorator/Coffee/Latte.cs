using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator
{
    public class Latte : ICoffee
    {
        public string Description()
        {
            return "Latte";
        }
        public int Cost()
        {
            return 5500;
        }


        
    }
}