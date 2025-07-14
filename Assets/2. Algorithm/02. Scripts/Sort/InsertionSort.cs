using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    private void Start()
    {
        Debug.Log("before array : " + string.Join(", ", array));

        Insertion(array);
        Debug.Log("after array : " + string.Join(", ", array));
    }

    private void Insertion(int[] arr)
    {
        int n = arr.Length;

        for ( int i = 0; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while(j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j - 1] = key;
        }
    }
}
