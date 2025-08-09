using Pattern.Factory;
using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Factory.Monster_Factory
{
    public class OrcWarrior : Monster
    {
        private void Awake()
        {
            Initialize("Orc Warrior", 150, 50);
        }
    }
}