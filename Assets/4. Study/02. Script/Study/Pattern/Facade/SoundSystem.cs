using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Facade
{
    public class SoundSystem : MonoBehaviour
    {

        public void StartSound(string soundName)
        {
            Debug.Log($"{soundName} play");
        }

        public void PauseSound(string soundName)
        {
            Debug.Log($"{soundName} pause");
        }

        public void StopSound(string soundName)
        {
            Debug.Log($"{soundName} end");
        }
    }
}