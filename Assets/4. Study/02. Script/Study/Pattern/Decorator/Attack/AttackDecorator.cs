using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack
{
    public class AttackDecorator : IAttack
    {
        protected IAttack attack;

        public AttackDecorator(IAttack attack)
        {
            this.attack = attack;
        }
        public virtual void Execute()
        {
            attack.Execute();
        }

    }
}