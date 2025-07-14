using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    private void Start()
    {
        Debug.Log($"Before sort : "+ string.Join(", ", array));

        Selection(array);

        Debug.Log($"After sort : " + string.Join(", ", array));
    }

    private void Selection(int[] arr)
    {
        int n = arr.Length;

        // choose specific value
        for(int i = 0; i < n - 1; i++) // i : index you choose
        {
            int minIdx = i;

            // compare the rest of values
            for(int j = i+1; j < n; j++) // j : index that will be compared
            {
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
                int temp = arr[i];
                arr[i] = arr[minIdx];
                arr[minIdx] = temp;
            }
        }
    }
}
