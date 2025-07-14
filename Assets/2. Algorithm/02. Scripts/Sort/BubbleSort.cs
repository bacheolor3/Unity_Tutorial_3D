using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    private void Start()
    {
        Debug.Log("before array : " + string.Join(", ", array));

        Bubble(array);
        Debug.Log("after array : " + string.Join(", ", array));
    }

    private void Bubble(int[] arr)
    {
        int n = arr.Length;

        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[ j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
