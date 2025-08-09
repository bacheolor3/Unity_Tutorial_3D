using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack
{
    public class IceAttack : AttackDecorator
    {
        public IceAttack(IAttack attack) : base(attack)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Debug.Log("Ice type bonus Damage");
        }
    }
}