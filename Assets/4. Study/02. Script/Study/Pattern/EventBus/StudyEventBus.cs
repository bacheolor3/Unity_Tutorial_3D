using System;
using UnityEngine;

public static class StudyEventBus 
{
    public static event Action onStarted;
    public static event Action<int> onScoreChanged;

    public static void StartEvent()
    {
        onStarted?.Invoke();
    }

    public static void ScoreChanged(int newScore)
    {
        onScoreChanged?.Invoke(newScore);
    }
}
