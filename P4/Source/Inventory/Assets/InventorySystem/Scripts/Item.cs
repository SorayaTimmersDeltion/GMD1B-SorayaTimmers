using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;
    public int itemWorth;
    public float itemWeight;
    public InventoryManager inventoryManagerScript;

    //Als er op de item geklikt wordt, krijgt deze de positie van de muis
    public void OnClick()
    {
        inventoryManagerScript.selectedItem = gameObject.transform;
    }
}
