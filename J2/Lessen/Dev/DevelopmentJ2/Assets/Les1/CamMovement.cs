using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Vector3 axis;
    public float hor;
    public float ver;
    public float camSpeed;

    public Vector3 mouseOrigin;
    public bool camRotation;
    public float turnSpeed;

	// Update is called once per frame
	void Update ()
    {
        cameraMovement();
	}

    public void cameraMovement()
    {
        // Horizontale verplaatsing van de character
        hor = Input.GetAxis("Horizontal");
        // De verplaatsing vindt plaats op de x-as van de vector3
        axis.x = hor;

        // Verticale verplaatsing van de character
        ver = Input.GetAxis("Vertical");
        //de verplaatsing vindt plaats op de z-as van de vector3
        axis.y = ver;

        // De snelheid van de verplaatsingen
        transform.Translate(axis * Time.deltaTime * camSpeed);

        //De rotatie met de muisscroll
        if(Input.GetMouseButtonDown(2))
        {
            mouseOrigin = Input.mousePosition;
            camRotation = true;
        }

        if (Input.GetMouseButtonUp(2))
        {
            camRotation = false;
        }

        if (camRotation)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
        }

    }
}
