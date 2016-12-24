using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    // een element is een index

    // een lijst van booleans
    public List<bool> b = new List<bool>();

	// Use this for initialization
	void Start ()
    {
        //index nr.4 wordt true gezet
        b[4] = true;

        //forloop
        for (int i = 0; i<10; i++)
        {
            if(b[i] == true)
            {
                print("True");
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
