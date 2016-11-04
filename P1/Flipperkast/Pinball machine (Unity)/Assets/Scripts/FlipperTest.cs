using UnityEngine;
using System.Collections;

public class FlipperTest : MonoBehaviour {

    public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
}
