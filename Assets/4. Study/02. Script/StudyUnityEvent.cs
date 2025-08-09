using UnityEngine;
using UnityEngine.Events;

public class StudyUnityEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent onUnityEvent;

    private void Start()
    {
        //onUnityEvent += MethodA;
        onUnityEvent.AddListener(MethodA);
        onUnityEvent.RemoveListener(MethodA);

        onUnityEvent.RemoveAllListeners();
    }

    void OnEnable()
    {
        onUnityEvent.AddListener(MethodA);
        onUnityEvent.AddListener(MethodC);
    }

    void OnDisable()
    {
        onUnityEvent.RemoveListener(MethodA);

        onUnityEvent.RemoveAllListeners();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onUnityEvent?.Invoke();
        }
    }

    public void AddMethod(UnityAction action)
    {
        onUnityEvent.AddListener(action);
    }

    private void MethodA()
    {
        Debug.Log("Method A");
    }

    private void MethodC()
    {
        Debug.Log("Method C");
    }
}
