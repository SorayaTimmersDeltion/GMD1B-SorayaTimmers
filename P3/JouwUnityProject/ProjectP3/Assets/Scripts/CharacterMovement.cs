using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 axis;
    public float hor;
    public float ver;
    public float walkSpeed;
    public float runSpeed;


    public Vector3 jumpPower;
    public float jumpCount;
    public Rigidbody characterRig;

    private Animator walking;
    private float vert;

    void Start()
    {
        walking = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharMovement();

        Run();

        vert = Input.GetAxis("Vertical");
    }

    void CharMovement()
    {
        // Horizontale verplaatsing van de character
        hor = Input.GetAxis("Horizontal");
        // De verplaatsing vindt plaats op de x-as van de vector3
        axis.x = hor;

        // Verticale verplaatsing van de character
        ver = Input.GetAxis("Vertical");
        //de verplaatsing vindt plaats op de z-as van de vector3
        axis.z = ver;

        // De snelheid van de verplaatsingen
        transform.Translate(axis * Time.deltaTime * walkSpeed);
    }

    void Run()
    {
        //Op het moment dat shift wordt ingedrukt, verhoogt de walkSpeed van de character met de runSpeed
        if (Input.GetButtonDown("Fire3"))
        {
            walkSpeed *= runSpeed;
        }

        // Als shift wordt losgelaten, wordt de walkSpeed verlaagd naar de oude snelheid;
        if (Input.GetButtonUp("Fire3"))
        {
            walkSpeed /= runSpeed;
        }
    }
}
