using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStackManager : MonoBehaviour
{
    public Stack<GameObject> uiStack = new Stack<GameObject>();

    public Button[] buttons;
    public GameObject[] popupUIs;

    private void Start()
    {
        // buttons[0].onClick.AddListener(함수명() => 기능);
        // buttons[0].onClick.AddListener(() => popupUIs[0].SetActive(true));

        buttons[0].onClick.AddListener(PopupOn1);
        buttons[1].onClick.AddListener(PopupOn2);
        buttons[2].onClick.AddListener(PopupOn3);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject currUI = uiStack.Pop();
            currUI.SetActive(false);
        }
    }

    void PopupOn1()
    {
        popupUIs[0].SetActive(true);
        uiStack.Push(popupUIs[0]);
    }
    void PopupOn2()
    {
        popupUIs[1].SetActive(true);
        uiStack.Push(popupUIs[1]);
    }
    void PopupOn3()
    {
        popupUIs[2].SetActive(true);
        uiStack.Push(popupUIs[2]);
    }
}
