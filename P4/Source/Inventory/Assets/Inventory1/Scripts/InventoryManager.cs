using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform selectedItem;
    public Transform selectedSlot;
    public Transform originalSlot;
    public Transform backGround;

    public GameObject inventoryPanel;
    public bool inventoryActive;

	// Use this for initialization
	void Start ()
    {
        inventoryPanel.SetActive(false); 
    }
	
	// Update is called once per frame
	void Update ()
    {
        ItemDrag();
        InventoryActivity();
    }

    public void ItemDrag()
    {
        if (Input.GetMouseButtonDown(0) && selectedItem != null)//the frame we press left button(so happens only ONCE)
        {
            originalSlot = selectedItem.parent;
            selectedItem.GetComponent<Collider>().enabled = false;//disable the collider so the slot collider behind it registrates that we are inside a slot collider
        }
        if (Input.GetMouseButton(0) && selectedItem != null)//if holding down left mouse button
        {
            selectedItem.position = Input.mousePosition;
            selectedItem.transform.SetParent(backGround);
        }
        else if (Input.GetMouseButtonUp(0) && selectedItem != null)//release left button
        {
            print("mouse release - selectedSlot is: " + selectedSlot);
            if (selectedSlot == null)
            {
                selectedItem.transform.SetParent(originalSlot);
            }
            else
            {
                selectedItem.transform.SetParent(selectedSlot, false);
            }
            selectedItem.localPosition = Vector3.zero;
            selectedItem.GetComponent<Collider>().enabled = true;//enable slot collider back to default
        }
    }

    public void InventoryActivity()
    {
        //Spatiebalk wordt ingedrukt
        if (Input.GetButtonDown("Jump"))
        {
            //Het schakelen van de bool inventoryActive
            inventoryActive = !inventoryActive;
            //De activiteit van de inventoryPanel verandert mee met de bool inventoryActive
            inventoryPanel.SetActive(inventoryActive);
        }
    }
}
