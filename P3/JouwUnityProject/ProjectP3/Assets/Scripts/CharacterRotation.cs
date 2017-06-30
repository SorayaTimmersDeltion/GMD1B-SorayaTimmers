using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    public GameObject characterCamera;
    public GameObject characterBody;
    public Vector3 cameraRotation;
    public Vector3 bodyRotation;

	// Use this for initialization
	void Start ()
    {
        characterBody.transform.parent = characterCamera.transform.parent;
	}
	
	// Update is called once per frame
	void Update ()
    {

        // Rotatie van de camera op de x-as
        cameraRotation.x = -Input.GetAxis("Mouse Y");

        characterCamera.transform.Rotate(cameraRotation);

        // Rotatie van de camera op de y-as
        bodyRotation.y = Input.GetAxis("Mouse X");

        characterBody.transform.Rotate(bodyRotation);

        // Rotatie van de body, waarbij de camera mee roteert
        characterBody.transform.Rotate(bodyRotation);
        transform.Rotate(cameraRotation);
    }
}