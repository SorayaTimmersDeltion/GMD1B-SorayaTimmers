using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject weapon;
    public GameObject barricade;

    public GameObject buttonObject;
    public GameObject character;
    public GameObject characterCamera;

	// Use this for initialization
	void Start ()
    {
        //Scripts van de betreffende objecten staan vanaf het begin uit
        weapon.GetComponent<WeaponMovement>().enabled = false;
        barricade.GetComponent<BarricadeMovement>().enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
        //De activiteit van het object buttonObject
        if (buttonObject.activeSelf)
        {
            character.GetComponent<CharacterMovement>().enabled = false;
            characterCamera.GetComponent<CharacterRotation>().enabled = false;
        }
        else
        {
            character.GetComponent<CharacterMovement>().enabled = true;
            characterCamera.GetComponent<CharacterRotation>().enabled = true;
        }
    }
}
