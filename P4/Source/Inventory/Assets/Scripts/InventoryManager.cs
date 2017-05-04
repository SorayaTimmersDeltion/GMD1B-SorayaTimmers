using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Sprite> itemImages = new List<Sprite>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void MouseOnClick()
    {
        //Ingedrukt houden van de linkermuis
        if (Input.GetMouseButton(0))
        {
            itemImages[0]
        }
    }
}
