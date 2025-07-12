using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolQueue : MonoBehaviour
{
    public Queue<GameObject> objQueue = new Queue<GameObject>(); // Queue where objects are comin in

    public GameObject objPrefab; // object will be processed
    public Transform parent; // parent object where structure needs

    private void Start()
    {
        CreateObject();
    }

    void CreateObject() // create object -> fill up Pool
    {
        for(int i = 0; i < 30; i++)
        {
            GameObject obj = Instantiate(objPrefab, parent); // create object, structure level changed as parent's child

            EnqueueObject(obj); // Directly Data input
        }
    }

    public void EnqueueObject(GameObject newObj)
    {
        newObj.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        newObj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        objQueue.Enqueue(newObj);
        newObj.SetActive(false); // object should not be function Active -> false
    }

     public GameObject DequeueObject() // function that required in time
    {
        if(objQueue.Count < 10)
        {
            CreateObject();
        }

        GameObject obj = objQueue.Dequeue();
        obj.SetActive(true);

        return obj;
    }
}
