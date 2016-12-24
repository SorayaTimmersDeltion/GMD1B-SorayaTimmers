using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

    private RaycastHit hit;
    public bool holdingObject;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (holdingObject)
            {
                transform.GetChild(0).parent = null;

                holdingObject = false;
            }
            else
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
                {
                    if (hit.transform.tag == "Enemy")
                    {
                        // Destroy(hit.transform.gameObject);  
                        // Enemy wordt een child van de camera  
                        hit.transform.SetParent(transform);

                        holdingObject = true;
                    }
                }
            }           
        }  
	}
}
