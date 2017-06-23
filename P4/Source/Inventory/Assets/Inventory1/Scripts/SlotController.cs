using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    public InventoryManager inventoryManagerScript;

    //parent = inventory; daarvan wordt het script InventoryManager gepakt en de selectedSlot wordt de transform van de muis
    public void OnClick()
    {
        inventoryManagerScript.selectedSlot = gameObject.transform;
    }
}
