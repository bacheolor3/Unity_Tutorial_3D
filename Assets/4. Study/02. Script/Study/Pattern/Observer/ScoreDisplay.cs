using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour, IObserver
{
    public ISubject subject;

    public TextMeshProUGUI scoreUI;

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
        scoreUI.text = score.ToString();
    }
}
