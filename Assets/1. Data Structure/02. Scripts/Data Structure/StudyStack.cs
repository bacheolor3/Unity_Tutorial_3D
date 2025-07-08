using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();
    public List<int> list1 = new List<int>();

    public int[] array = new int[3] {1, 2, 3};
    public int[] array2;

    private void Start()
    {
        stack = new Stack<int>(array);

        list1 = stack.ToList();
        array2 = stack.ToArray();
    }
}
