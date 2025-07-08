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

        // list1.Insert(5, 100); // �ε��� 5���� 100�� ����

        // list1.Remove(5); // ��5�� ����

        // list1.RemoveAt(5);  // �ε��� 5���� �ִ� ���� ����

        // list1.RemoveRange(1, 3); // �ε��� 1������ 3������ ����

        // list1.Clear(); // ������ ��� ����

        //list1.RemoveAll(x => x > 5); // ���� List �ȿ��� x > 5 ���� ��� ����


        if (list1.Contains(10)) // List���� 10�̶�� ���� ������ true
        {
            Debug.Log("�� 10�� ���� 0");
        }
        else
        {
            Debug.Log("�� 10�� ���� X");
        }
    }
}
