using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public Vector3 axis;

    public float ver;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        ver = Input.GetAxis("Vertical");

        axis.z = ver;
	    
	}
}
