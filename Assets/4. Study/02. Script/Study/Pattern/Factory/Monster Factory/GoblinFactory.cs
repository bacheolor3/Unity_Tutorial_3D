using Pattern.Factory;
using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Factory.Monster_Factory
{
    public class GoblinFactory : MonsterFactory
    {
        public override Monster CreateMonster(string type)
        {
            switch (type)
            {
                case "Normal":
                    return new GameObject("Goblin").AddComponent<Goblin>();
                    break;
                case "Warrior":
                    return new GameObject("Goblin Warrior").AddComponent<Goblin>();
                    break;
                case "Archer":
                    return new GameObject("Goblin Archer").AddComponent<Goblin>();
                    break;
                default:
                    Debug.LogError($"Unknown Monster Type : {type}");
                    break;
            }
            return null;
        }
    }
}