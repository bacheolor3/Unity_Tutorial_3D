using System.Collections.Generic;
using UnityEngine;


namespace Pattern.Observer
{
    public class Player : ISubject
    {
        private int score;

        
        public int GetScore()
        {
            return score;
        }

        public void AddScore(int score)
        {
            this.score += score;
            Debug.Log("Current Score : "+ score);
            
            NotifyObservers();
        }

        private void CheckQuest()
        {
        }

        public List<IObserver> Observers { get; set; }


        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(var observer in Observers)
            {
                observer.Notify(score);
            }
        }
    }

}
