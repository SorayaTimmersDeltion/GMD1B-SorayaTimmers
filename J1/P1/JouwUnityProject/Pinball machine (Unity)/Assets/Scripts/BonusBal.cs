using UnityEngine;
using System.Collections;

public class BonusBal : MonoBehaviour {

    public Vector3 spawnLocation;

	// Use this for initialization
	void Start ()
    {
        spawnLocation = transform.position;
	}
	
    // Een extra bal spawnen
	public void SpawnBonusBall()
    {
        Instantiate(Resources.Load("BonusBal"), spawnLocation, Quaternion.identity);
    }
}
