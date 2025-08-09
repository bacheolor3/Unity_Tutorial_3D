using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Facade
{
    public class QuestSystem : MonoBehaviour
    {

        public void StartQuest(string questName)
        {
            Debug.Log($"{questName} added");
        }

        public void HasQuest(string questName)
        {
            Debug.Log($"{questName} check");
        }

        public void CompleteQuest(string questName)
        {
            Debug.Log($"{questName} giveup");
        }
    }
}