using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

    public float power;


   
    void OnCollisionEnter(Collision c)
    {
        //Versnelling van de bal
        c.gameObject.GetComponent<Rigidbody>().velocity *= power;

        // Rotatie bal
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }   

  
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
