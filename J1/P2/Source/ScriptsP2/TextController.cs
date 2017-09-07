using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public List<string> textList = new List<string>();

    public GameObject buttonObject;
    public Text text;

    public int textInt;

    public GameObject weapon;
    public GameObject barricade;

	// Use this for initialization
	void Start ()
    {
        text.text = (textList[0]);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Als de list bij de zesde string is, worden de scripts van de objecten weapon en barricade actief gezet
        if(textInt == 6)
        {
            weapon.GetComponent<WeaponMovement>().enabled = true;
            barricade.GetComponent<BarricadeMovement>().enabled = true;
        }
    }

    public void OnClick()
    {
        /*De text wordt met iedere klik op de linkermuisknop veranderd
          door gebruik van de volgende index in de list textList*/
        text.text = (textList[1 + textInt]);
        textInt++;

        /*Op het moment dat textInt bij de indexen 4,5 en 6 is, wordt het object buttonObject inactief gezet*/
        if(textInt == 4 || textInt == 5 || textInt == 6)
        {
            buttonObject.SetActive(false);            
        }
    }
}
