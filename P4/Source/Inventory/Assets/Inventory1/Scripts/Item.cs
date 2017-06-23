using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseEnter()
    {
        //parent.parent = slot; daarvan wordt het script InventoryManager gepakt en de selectedItem wordt de transform van de muis
        transform.parent.parent.GetComponent<InventoryManager>().selectedItem = this.transform;
    }
}
