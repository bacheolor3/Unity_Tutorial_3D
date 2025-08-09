using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Adapter
{
    public class LegacyPlayerAdapter : MonoBehaviour, ICharacter
    {
        private LegacyPlayer legacyPlayer;

        void Awake()
        {
            legacyPlayer = new LegacyPlayer();
        }
        public void Move(Vector3 dir)
        {
            legacyPlayer.LegacyMove(dir.x, dir.y, dir.z);
        }

        public void Attack()
        {
            legacyPlayer.LegacyAttack();
        }

    }
}