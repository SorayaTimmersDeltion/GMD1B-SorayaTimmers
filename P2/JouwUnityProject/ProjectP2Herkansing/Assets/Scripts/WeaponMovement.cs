using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public Animator weaponAnimator;
    public GameObject barricade;
    public GameObject weapon;

    void Start()
    {
        //De collider dat op het aangegeven object staat, staat vanaf het starten van het spel uit
        weapon.GetComponent<Collider>().enabled = false;
    }

    void Update ()
    {
        //Op het moment dat de speler op de linker muisknop drukt, wordt er een animatie afgespeeld
        if (Input.GetButtonDown("Fire1"))
        {
            weaponAnimator.SetTrigger("Attack");
            weapon.GetComponent<Collider>().enabled = true;

            StartCoroutine(WeaponSway(1));
        }     
    }

    IEnumerator WeaponSway(float f)
    {
        yield return new WaitForSeconds(1);
        weapon.GetComponent<Collider>().enabled = false;
    }

    void OnCollisionEnter(Collision c)
    {
        /* Als het wapen binnen de animatie het object met de tag Barricade raakt,
           wordt er in dat object het script BarricadeMovement de boolean gotHit aangezet*/
        if (c.gameObject.tag == "Barricade")
        {
            print("hit");
            barricade.GetComponent<BarricadeMovement>().gotHit = true;
        }
    }
}
