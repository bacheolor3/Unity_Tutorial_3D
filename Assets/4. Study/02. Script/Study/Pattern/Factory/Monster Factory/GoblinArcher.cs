using Pattern.Factory;
using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Factory.Monster_Factory
{
    public class GoblinArcher : Monster
    {
        private void Awake()
        {
            Initialize("Goblin Archer", 40, 30);
        }
    }
}