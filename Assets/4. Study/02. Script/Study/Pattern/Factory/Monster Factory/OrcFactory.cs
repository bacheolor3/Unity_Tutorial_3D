using Pattern.Factory;
using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Factory.Monster_Factory
{
    public class OrcFactory : MonsterFactory
    {
        public override Monster CreateMonster(string type)
        {
            switch (type)
            {
                case "Normal":
                    return new GameObject("Orc").AddComponent<Goblin>();
                    break;
                case "Warrior":
                    return new GameObject("Orc Warrior").AddComponent<Goblin>();
                    break;
                case "Archer":
                    return new GameObject("Orc Archer").AddComponent<Goblin>();
                    break;
                default:
                    Debug.LogError($"Unknown Monster Type : {type}");
                    break;
            }
            return null;
        }

        
    }
}