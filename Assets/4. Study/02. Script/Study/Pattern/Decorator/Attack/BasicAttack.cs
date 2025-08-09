using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack
{
    public class BasicAttack : IAttack
    {
        public void Execute()
        {
            Debug.Log("Execute Basic Attack");
        }

    }
}