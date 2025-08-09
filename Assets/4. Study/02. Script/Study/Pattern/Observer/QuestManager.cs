using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Assets._4._Study._02._Script
{
    public class QuestManager : MonoBehaviour, IObserver
    {
        private bool isQuestClear1 = false;
        private bool isQuestClear2 = false;
        private bool isQuestClear3 = false;

        public ISubject subject;

        private void OnEnable()
        {
            subject.AddObserver(this);
        }

        private void OnDisable()
        {
            subject.RemoveObserver(this);
        }

        public void Notify(int score)
        {
            if (score >= 100 && !isQuestClear1)
            {
                isQuestClear1 = true;
                Debug.Log("100 point achieve");
            }
            else if (score >= 500 && !isQuestClear2)
            {
                isQuestClear2 = true;
                Debug.Log("500 point achieve");
            }
            else if (score >= 1000 && !isQuestClear3)
            {
                isQuestClear3 = true;
                Debug.Log("1000 point achieve");
            }
        }
    }
}