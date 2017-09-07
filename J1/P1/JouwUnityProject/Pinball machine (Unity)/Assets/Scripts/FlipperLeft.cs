using UnityEngine;
using System.Collections;

public class FlipperLeft : MonoBehaviour
{

    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge;

    // Use this for initialization
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Afschieten van de Linker flipper
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 f = (-(transform.right)) * flipperStrength;
            Vector3 p = (transform.up) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
    }
}
