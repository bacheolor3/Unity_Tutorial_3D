using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public void AddItem(string itemName)
    {
        Debug.Log($"{itemName} added");
    }

    public void HasItem(string itemName)
    {
        Debug.Log($"{itemName} check");
    }

    public void RemoveItem(string itemName)
    {
        Debug.Log($"{itemName} removed");
    }
}
