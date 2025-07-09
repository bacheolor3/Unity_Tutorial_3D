using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right };
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();
    
    private void OnMouseDown() // Enable when had collider
    {
        if (!HanoiTower.isSelected) // not selected
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // after selected
        {           
            PushDonut(HanoiTower.selectedDonut);
        }
    }

    public bool CheckDonut(GameObject donut)
    {
        if (barStack.Count > 0) 
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;
            GameObject peekDonut = barStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;

            if(pushNumber < peekNumber)
            {
                return true;
            }
            else 
            {
                Debug.Log($"Current Donut number is {pushNumber}, Current Pillar's peak Donut number is {peekNumber}");
                return false;
            }
        }

        return true;
    }

    public void PushDonut(GameObject donut)
    {
        if (!CheckDonut(donut))
        {
            return;
        }

        HanoiTower.isSelected = false;
        HanoiTower.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 5f;
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        barStack.Push(donut); // Put GameObject into Stack
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Pullout GameObject from Stack

        return donut; // Return pullout donut
    }
}
