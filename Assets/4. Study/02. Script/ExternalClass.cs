using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    private StudyUnityEvent studyUnityEvent;

    void Awake()
    {
        studyUnityEvent = FindFirstObjectByType<StudyUnityEvent>();
    }

    void Start()
    {
        //ButtonManager.emergencyStopButton += TimerView;
    }

    private void TimerView()
    {

    }


    void Update()
    {
        //if (ButtonManager.Instance.isSingleton)
        //{
        //    //TimerView();
        //}
    }
    

    private void MethodB()
    {
        Debug.Log("Method B");
    }

}
