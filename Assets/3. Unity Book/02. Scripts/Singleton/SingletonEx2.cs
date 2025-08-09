using UnityEngine;

public class SingletonEx2 : MonoBehaviour
{
    public static SingletonEx2 instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
