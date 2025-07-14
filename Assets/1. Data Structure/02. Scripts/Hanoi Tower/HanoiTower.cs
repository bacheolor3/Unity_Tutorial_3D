using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HanoiTower : MonoBehaviour
{
    public enum HanoiLevel { Lv1 = 3, Lv2, Lv3 };
    public HanoiLevel hanoiLevel = HanoiLevel.Lv1;

    public GameObject[] donutPrefabs;
    public BoardBar[] bars; // L, C, R

    public TextMeshProUGUI countTextUI;
    public Button answerButton;

    public static GameObject selectedDonut;
    public static bool isSelected;
    public static BoardBar currBar;
    public static int moveCount;

    private void Awake()
    {
        answerButton.onClick.AddListener(HanoiAnwer);
    }

    private IEnumerator Start()
    {        
        for(int i = (int)hanoiLevel - 1; i >=0;  i--) // create donut by Level using repeat
        {
            GameObject donut = Instantiate(donutPrefabs[i]); // create donut
            donut.transform.position = new Vector3(-5f, 5f, 0); // donut creat position : left stick + upper

            bars[0].PushDonut(donut); // Push the recent respawned donut into certain Bar

            yield return new WaitForSeconds(1f); // created by number
        }

        moveCount = 0;
        countTextUI.text = moveCount.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currBar.barStack.Push(selectedDonut);

            isSelected = false;
            selectedDonut = null;
        }
        countTextUI.text = moveCount.ToString();
    }

    void HanoiAnwer()
    {
        HanoiRoutine((int)hanoiLevel, 0, 1, 2);
    }

    private void HanoiRoutine(int n, int from, int temp, int to)
    {
        if (n == 0)
        {
            return;
        }

        if( n == 1)
        {
            Debug.Log($"no.{n} donut is moving to {to} from {from}");
        }
        else
        {
            HanoiRoutine(n - 1, from, to, temp);
            Debug.Log($"no.{n} donut is moving to {to} from {from}");
            HanoiRoutine(n - 1, temp, from, to);
        }
    }
}
