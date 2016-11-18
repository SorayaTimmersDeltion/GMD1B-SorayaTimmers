using UnityEngine;
using System.Collections;

public class SphereSpawns : MonoBehaviour {

    public GameObject prefab;

    public float x;
    public float y;
    public float z;

    public Vector3 position;

	// Use this for initialization
	void Start ()
    {
        x = Random.Range(0, 1200);
        y = 582;
        z = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Instantiate(Resources.Load("Sphere"));
    }
}
