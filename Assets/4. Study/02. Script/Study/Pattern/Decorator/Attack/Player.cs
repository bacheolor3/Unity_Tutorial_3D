using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack
{
    public class Player : MonoBehaviour
    {

        private void Start()
        {
            IAttack attack = new BasicAttack();

            attack = new FireAttack(attack);
            attack.Execute();

            attack = new IceAttack(attack);
            attack.Execute();
        }
    }
}