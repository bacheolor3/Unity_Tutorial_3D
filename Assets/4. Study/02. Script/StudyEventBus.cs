using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script
{
    public class StudyEventBus : MonoBehaviour
    {
        public static event Action onEventAction;
        public static event Action<int> onScoreChanged;

        public void StartEvent()
        {
            // onStart?.Invoke();
        }

        public static void ScoreChanged(int newScore)
        {
            onScoreChanged?.Invoke(newScore);
        }
    }
}
