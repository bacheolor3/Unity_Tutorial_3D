using UnityEngine;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform parentRect;

    private Vector2 basePos;
    private Vector2 startPos;
    private Vector2 moveOffset;

    void Awake()
    {
        parentRect = transform.parent.GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        basePos = parentRect.anchoredPosition; // Original UI Position
        startPos = eventData.position; // start point
    }

    public void OnDrag(PointerEventData eventData)
    {
        moveOffset = eventData.position - startPos; // Dir when Dragged
        parentRect.anchoredPosition = basePos + moveOffset;
    }
}
