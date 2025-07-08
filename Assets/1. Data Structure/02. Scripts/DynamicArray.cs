using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>() { 1, 2, 3};

    private void Start()
    {       
        for (int i = 1; i< 10; i++)
        {
            list1.Add(i);
        }

        // list1.Insert(5, 100); // 인덱스 5번에 100을 삽입

        // list1.Remove(5); // 값5를 제거

        // list1.RemoveAt(5);  // 인덱스 5번에 있는 값을 제거

        // list1.RemoveRange(1, 3); // 인덱스 1번에서 3개까지 제거

        // list1.Clear(); // 데이터 모두 제거

        //list1.RemoveAll(x => x > 5); // 현재 List 안에서 x > 5 값은 모두 제거


        if (list1.Contains(10)) // List에서 10이라는 값이 있으면 true
        {
            Debug.Log("값 10이 존재 0");
        }
        else
        {
            Debug.Log("값 10이 존재 X");
        }
    }
}
