using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {

    public Vector3 axis;

    public float hor;

    public float speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        hor = Input.GetAxis("Horizontal");

        axis.x = hor;

        transform.Translate(axis * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision c)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().lifesCount -= 1;
    }
}
