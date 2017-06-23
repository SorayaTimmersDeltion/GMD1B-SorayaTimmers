using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;
    public int itemWorth;
    public float itemWeight;
    public InventoryManager inventoryManagerScript;

    public void OnClick()
    {
        inventoryManagerScript.selectedItem = gameObject.transform;
    }
}
