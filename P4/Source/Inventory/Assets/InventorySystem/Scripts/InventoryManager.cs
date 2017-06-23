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

    public Text itemInformationText;

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

        itemInformationText.text = selectedItem.name + " - " + ("Weight: ") + selectedItem.GetComponent<Item>().itemWeight;
    }

    public void ItemDrag()
    {
        //Het indrukken van de linkermuisknop
        if (Input.GetMouseButtonDown(0) && selectedItem != null)
        {
            //De collider van het item wordt disabled, zodat de collider van de slot kan registreren dat de speler boven op het slot staat
            originalSlot = selectedItem.parent;
            selectedItem.GetComponent<Collider>().enabled = false;
        }
        //Het ingedrukt houden van de linkermuisknop
        if (Input.GetMouseButton(0) && selectedItem != null)
        {
            //Het item volgt de muis
            selectedItem.position = Input.mousePosition;
            selectedItem.transform.SetParent(backGround);
        }
        //Het loslaten van de linkermuisknop
        if (Input.GetMouseButtonUp(0) && selectedItem != null)
        {
            //De selectedItem wordt in de originalSlot gestopt als deze leeg is
            if (selectedSlot == null)
            {
                selectedItem.transform.SetParent(originalSlot);
            }
            //De selectedItem wordt teruggezet naar de huidige slot
            else
            {
                selectedItem.transform.SetParent(selectedSlot);
            }
            //Positie van de selectedItem wordt gezet naar de huidige positie
            selectedItem.localPosition = Vector3.zero;
            //De collider van de selectedItem wordt enabled
            selectedItem.GetComponent<Collider>().enabled = true;
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
