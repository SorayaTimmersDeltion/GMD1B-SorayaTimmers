using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

    void OnCollisionEnter()
    {
       
        GameObject.Find("Scorecube"). GetComponent<Score>().Plus();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
          
	}

}
