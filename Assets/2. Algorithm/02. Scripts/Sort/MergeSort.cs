using UnityEngine;

public class MergeSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    private void Start()
    {
        Debug.Log("before array : " + string.Join(", ", array));
        MSort(array, 0, array.Length - 1);
        Debug.Log("after array : " + string.Join(", ", array));
    }

    private void MSort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int mid = left + (right - left) / 2;

            MSort(arr, left, mid);
            MSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    private void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1; // left array size
        int n2 = right - mid; // right array size

        int[] leftArr = new int[n1]; // temp array size set
        int[] rightArr = new int[n2]; // temp array size set

        for (int i = 0; i < n1; i++) // left array reset
            leftArr[i] = arr[left + i];
        for(int i = 0; i < n2; i++) // right array reset       
            rightArr[i] = arr[mid + 1 + i];

        int j = left; // original array startpoint
        int u = 0, v = 0; // temp varient num for repeat

        while(u < n1 && v < n2)
        {
            if (leftArr[u] <= rightArr[v])
            {
                arr[j] = leftArr[u];
                u++;
            }
            else
            {
                arr[j] = rightArr[u];
                v++;
            }
            j++;
        }
        while(u < n1)
        {
            arr[j] = leftArr[u];
            u++;
            j++;
        }

        while(v < n2)
        {
            arr[j] = rightArr[v];
            v++;
            j++;
        }
    }
}
