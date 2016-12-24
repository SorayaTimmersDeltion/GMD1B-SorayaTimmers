using UnityEngine;
using System.Collections;

public class FroggerMovement : MonoBehaviour {

    public Vector3 axis;

    public float hor;
    public float ver;

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bewegen op de z-as
        hor = Input.GetAxis("Horizontal");

        axis.x = hor;
        
        //bewegen op de x-as
        ver = Input.GetAxis("Vertical");

        axis.z = ver;

        transform.Translate(axis * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision c)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().lifesCount -= 1;
    }
}
