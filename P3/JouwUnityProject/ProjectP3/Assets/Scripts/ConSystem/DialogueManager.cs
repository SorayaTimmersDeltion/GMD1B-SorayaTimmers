using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    RaycastHit hit;
    public float raycastLength;

    //public Dialogue dialogueScript;
    public UIManager uiScript;
    public Dialogue dialogueScript;

    public int indexNumber;
    public int answer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void conversationRayCast()
    {
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.green, 0.2f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength))
        {
            if(hit.collider.tag == "NPC")
            {
                dialogueScript = hit.collider.GetComponent<Dialogue>();

                if (Input.GetButtonDown("Jump"))
                {
                    indexNumber = 0;
                    if (Input.GetKeyDown("y"))
                    {
                        indexNumber 
                    }
                }

            }
        }
    }
}
