using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake_movement : MonoBehaviour
{
    public Vector3 axis;
    public float horMovement;
    public float vertMovement;
    public float speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        SnakeMovement();
    }

    public void SnakeMovement()
    {
        horMovement = Input.GetAxis("Horizontal");
        axis.x = horMovement;

        vertMovement = Input.GetAxis("Vertical");
        axis.z = vertMovement;

        transform.forward = axis;

        gameObject.transform.Translate(transform.forward * Time.deltaTime * speed);

    }
}
