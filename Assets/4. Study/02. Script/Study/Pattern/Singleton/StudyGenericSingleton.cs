using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script
{
    public class StudyGenericSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;
        public static T Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = FindFirstObjectByType<T>();

                    if(instance == null)
                    {
                        var newObject = new GameObject(typeof(T).ToString());
                        instance = newObject.AddComponent<T>();
                    }
                }

                return instance;
            }
        }

        protected virtual void Awake()
        {
            if(instance == null)
            {
                instance = this as T;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}