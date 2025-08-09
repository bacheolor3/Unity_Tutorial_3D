using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Adapter
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject player;

        private ICharacter character;

        private void Start()
        {
            character = player.GetComponent<ICharacter>();

            character.Move(Vector3.forward);
            character.Attack();

            LegacyPlayer legacyPlayer = new LegacyPlayer();
            legacyPlayer.LegacyMove(0, 0, 1);
        }
    }
}