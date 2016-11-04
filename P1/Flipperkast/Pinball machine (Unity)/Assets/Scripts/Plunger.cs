using UnityEngine;
using System.Collections;

public class Plunger : MonoBehaviour {

    public float force;

   	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay(Collision c)
    {
        if(Input.GetButtonDown("Jump"))
        c.rigidbody.AddForce(transform.up * force);
    }

}
