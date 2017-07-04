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

	
	// Update is called once per frame
	void Update ()
    {
        Jump();

        Movement();

        Run();
    }

    void Movement()
    {
        // Horizontale verplaatsing van de character
        hor = Input.GetAxis("Horizontal");
        // De verplaatsing vindt plaats op de x-as van de vector3
        axis.z = hor;

        // Verticale verplaatsing van de character
        ver = Input.GetAxis("Vertical");
        //de verplaatsing vindt plaats op de z-as van de vector3
        axis.x = -ver;

        // De snelheid van de verplaatsingen
        transform.Translate(axis * Time.deltaTime * walkSpeed);
    }

    void Jump()
    {
        // Het springen van de character
        if (Input.GetButtonDown("Jump"))
        {
            /*Bij een jumpCount onder de 1, wordt er bij een sprong 1 opgeteld 
            en een velocity van de jumpPower toegevoegd*/
            if (jumpCount < 1)
            {
                characterRig.velocity = jumpPower;
                jumpCount += 1;
            }
        }
    }

    void OnCollisionEnter(Collision c)
    {
        /*bij collision met een object met de tag JumpReset, wordt de jumpCount naar 0 gezet. 
          Hierdoor kan de speler opnieuw springen*/
        if (c.gameObject.tag == "JumpReset")
        {
            jumpCount = 0;
        }
    }

    void Run()
    {
        //Op het moment dat shift wordt ingedrukt, verhoogt de walkSpeed van de character met de runSpeed
        if (Input.GetButtonDown("Fire3"))
        {
            walkSpeed *= runSpeed;
        }

        // Als shift wordt losgelaten, wordt de walkSpeed verlaagd naar de oude snelheid;
        if(Input.GetButtonUp("Fire3"))
        {
            walkSpeed /= runSpeed;
        }
    }
}
