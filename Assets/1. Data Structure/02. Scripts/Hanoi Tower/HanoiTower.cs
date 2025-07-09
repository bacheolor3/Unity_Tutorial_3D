using System.Collections;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 };
    public HanoiLevel hanoiLevel;

    public GameObject[] donutPrefabs;
    public BoardBar[] bars; // L, C, R

    public static GameObject selectedDonut;
    public static bool isSelected;

    private IEnumerator Start()
    {
        for(int i = (int)hanoiLevel - 1; i >=0;  i--) // create donut by Level using repeat
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // create donut
            donut.transform.position = new Vector3(-5f, 5f, 0); // donut creat position : left stick + upper

            bars[0].PushDonut(donut); // Push the recent respawned donut into certain Bar

            yield return new WaitForSeconds(1f); // created by number
        }
    }
}
