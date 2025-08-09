using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack
{
    public class FireAttack : AttackDecorator
    {
        public FireAttack(IAttack attack) : base(attack)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Debug.Log("Fire type bonus Damage");
        }
    }
}