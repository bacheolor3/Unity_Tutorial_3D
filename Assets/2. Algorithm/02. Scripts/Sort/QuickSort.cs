using System.Collections.Concurrent;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    private void Start()
    {
        Debug.Log("before array : " + string.Join(", ", array));

        Quick(array, 0, array.Length - 1);
        Debug.Log("after array : " + string.Join(", ", array));
    }

    private void Quick(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int pivot = Partition(arr, left, right);

            Quick(arr, left, pivot - 1);
            Quick(arr, pivot + 1, right);
        }
    }

    private int Partition(int[] arr, int left, int right)  // using pivot to separate -> conquering function
    {
        int pivot = arr[right];
        int index = left - 1;

        for(int i = left; i < right; i++)
        {
            if (arr[i] < pivot)
            {
                index++;

                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }

        int temp2 = arr[index + 1];
        arr[index + 1] = arr[right];
        arr[right] = temp2;

        return index + 1;
    }
}
