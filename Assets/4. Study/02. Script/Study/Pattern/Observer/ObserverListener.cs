using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script
{
    public class ObserverListener : MonoBehaviour, IObserver
    {
        public Subject subject;

        private void OnEnable()
        {
            subject.AddObserver(this);
        }

        private void OnDisable()
        {
            subject.RemoveObserver(this);
        }

        public void Notify(int hp)
        {
            if(hp <= 0)
            {
                Debug.Log("Boss Monster Clear");
            }
        }
    }
}