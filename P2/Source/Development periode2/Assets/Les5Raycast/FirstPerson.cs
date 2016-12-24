using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour
{
    public Vector3 rotation;

    public GameObject body;
    public Vector3 bodyRotation;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Rotatie op de x-as
        rotation.x = -Input.GetAxis("Mouse Y");

        //Rotatie op de y-as
        bodyRotation.y = Input.GetAxis("Mouse X");
        //Body-rotatie
        body.transform.Rotate(bodyRotation);
        
        transform.Rotate(rotation);
	}
}
