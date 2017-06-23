using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseEnter()
    {    
        //parent = inventory; daarvan wordt het script InventoryManager gepakt en de selectedSlot wordt de transform van de muis
        transform.parent.GetComponent<InventoryManager>().selectedSlot = this.transform;
    }
}
