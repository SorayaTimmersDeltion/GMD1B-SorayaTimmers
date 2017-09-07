using UnityEngine;
using System.Collections;

public class SphereInstantiate : MonoBehaviour {

    public GameObject prefab;
    public Vector3 spawnPosition;

    public Vector3 power;
    public Rigidbody rig;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Fire2"))
        {
            GameObject newBall = (GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity);
            
             newBall.GetComponent<Rigidbody>().velocity = power;            
        }
	}
}
