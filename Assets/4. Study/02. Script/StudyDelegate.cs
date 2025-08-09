using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.UI;

public class StudyDelegate : MonoBehaviour
{
    public delegate void MyDelegate();
    public static MyDelegate onKeyDown;

    public KeyCode keyCode = KeyCode.Space;

    public float timer;

    public bool isTimer = true;

    public Button button;

    private void Start()
    {
        AddMethod(Respond);
        AddMethod(StopTimer);
        AddMethod(StopBomb);
    }

    private void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
        }

        if (Input.GetKeyDown(keyCode))
        {
            onKeyDown?.Invoke();
        }
    }

    public void AddMethod(MyDelegate myDelegate)
    {
        onKeyDown += myDelegate;
    }

    private void Respond()
    {
        Debug.Log("Key is pushed");
    }

    private void StopTimer()
    {
        isTimer = false;
        Debug.Log("Timer Stop");
    }

    private void StopBomb()
    {
        Debug.Log("Bomb function Deactivate");
    }

    //public delegate void MyDelegate();

    //public MyDelegate myDelegate;

    //private void Start()
    //{
    //    // myDelegate = new MyDelegate(MethodA);

    //    // myDelegate();

    //    // myDelegate.Invoke();

    //    // or

    //    //if(myDelegate != null)
    //    //{
    //    //    myDelegate.Invoke();
    //    //}

    //    // myDelegate? Invoke();

    //    // Invoke("MethodA", 3f);

    //    //myDelegate = MethodA;

    //    //myDelegate?.Invoke();

    //    //myDelegate = MethodA;

    //    //myDelegate += MethodB;
    //    //myDelegate += MethodC;

    //    //myDelegate -= MethodB;

    //    //myDelegate = MethodB;

    //    //myDelegate?.Invoke();
    //}

    //private void MethodA()
    //{
    //    Debug.Log("Method A");
    //}

    ////public enum MonsterState { A, B, C };

    ////public MonsterState state;

    ////public void MethodA()
    ////{
    ////}

    //private void MethodB()
    //{
    //    Debug.Log("Method B");
    //}

    //private void MethodC()
    //{
    //    Debug.Log("Method C");
    //}


}
