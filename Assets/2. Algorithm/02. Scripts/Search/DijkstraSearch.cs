using UnityEditor;
using UnityEngine;

public class DijkstraSearch : MonoBehaviour
{
    private int[,] nodes = new int[6, 6]
    {
      // 0  1  2  3  4  5
        {0, 1, 2, 0, 4, 0, }, // 1
        {1, 0, 0, 0, 0, 8, }, // 2
        {2, 0, 0, 3, 0, 0, }, // 3
        {0, 0, 3, 0, 0, 0, }, // 4
        {4, 0, 0, 0, 0, 2, }, // 5
        {0, 8, 0, 0, 2, 0, }, // 6
    };

    private void Start()
    {
        int start = 0;
        int[] dist;
        int[] prev;
        
        Dijkstra(start, out dist, out prev);

        for(int i = 0; i < nodes.GetLength(0); i++)
        {
            Debug.Log($"from {start} to {i} shortes route: {dist[i]}, route: {GetPath(i, prev)}");
        }
        // Debug.Log(VAR);
    }

    private void Dijkstra(int start, out int[] dist, out int[] prev)
    {
        int n = nodes.GetLength(0); // 6 row 6 col
        dist = new int[n];
        prev = new int[n];
        bool[] visited = new bool[n];
        
        // reset local value
        for(int i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue; // 2,147,483,647
            prev[i] = -1;
            visited[i] = false;
        }

        dist[start] = 0; // start in 0 node
        for(int cnt = 0; cnt < n; cnt++)
        {
            int u = -1; // shortest node
            int min = int.MaxValue; // shortest route


            // find the node that neve visited and shortest route and node
            for(int j = 0; j < n; j++)
            {
                if (!visited[j] && dist[j] < min)
                {
                    min = dist[j];
                    u = j;
                }
            }

            if (u == -1) // no more shortest route node
            {
                break;
            }

            visited[u] = true;

            for(int k = 0; k < n; k++)
            {
                if (nodes[u, k] > 0 && !visited[k])
                {
                    int newDist =  dist[u] + nodes[u, k];
                    if(newDist < dist[k])
                    {
                        dist[k] = newDist;
                        prev[k] = u;
                    }
                }
            }
        }
    }

    private string GetPath(int end, int[] prev)
    {
        if (prev[end] == -1)
        {
            return end.ToString();
        }

        return $"{GetPath(prev[end], prev)} -> {end.ToString()}";
    }
}
