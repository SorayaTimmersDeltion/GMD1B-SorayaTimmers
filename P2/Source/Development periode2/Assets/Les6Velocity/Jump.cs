using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public Vector3 jump;
    public Rigidbody rig;

    public float xjumps;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (xjumps < 3)
            {
                rig.velocity = jump;
                xjumps += 1;
            }
        }   
	}

    void OnCollisionEnter()
    {
        xjumps = 0;
    }
}
