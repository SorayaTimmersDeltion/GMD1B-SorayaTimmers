using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    public InventoryManager inventoryManagerScript;

    //Er wordt geklikt op een slot
    public void OnClick()
    {
        inventoryManagerScript.selectedSlot = gameObject.transform;
    }
}
