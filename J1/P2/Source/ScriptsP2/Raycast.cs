using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private RaycastHit hit;
    public float range;
    public float wingEmission;

    public GameObject wings;

    public List<GameObject> levelUps = new List<GameObject>();
    public GameObject mazeBarricade;

    public int loopCounter;

    public Transform characterPosition;
    public Transform startPosition;
    public float respawnTimer;

    public GameObject weapon;
    public GameObject barricade;

    public GameObject buttonObject;

	// Update is called once per frame
	void Update ()
    {
        RaycastOnHit();
    }

    void RaycastOnHit()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            /*Bij het indrukken van de rechter muisknop wordt er een raycast geschoten,
              die in de scène visueel wordt laten zien*/
            Debug.DrawRay(transform.position, transform.forward * range, Color.green);

            if (Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                /*Wanneer er met de raycast een object wordt geraakt met de tag PowerUp,
                  worden van twee genoemde objecten de scripts aangezet*/
                if (hit.transform.tag == "PowerUp")
                {
                    buttonObject.SetActive(true);

                    /*weapon.GetComponent<WeaponMovement>().enabled = true;
                    barricade.GetComponent<BarricadeMovement>().enabled = true;*/
                }

                //Wanneer er met de raycast een object wordt geraakt met de tag LevelUps, wordt:
                if (hit.transform.tag == "LevelUps")
                {
                    //Het object dat wordt geraakt, wordt in de list levelups gezet
                    levelUps.Add(hit.transform.gameObject);

                    //Van beide objecten wordt de emission veranderd met de hoeveelheid aangegeven met de wingEmission
                    hit.transform.gameObject.GetComponent<Renderer>().material.SetFloat("_Emission", +wingEmission);
                    wings.GetComponent<Renderer>().material.SetFloat("_Emission", +wingEmission);

                    //De collider van het geraakte object uitgezet
                    hit.transform.gameObject.GetComponent<Collider>().enabled = false;

                    //Een forloop dat checkt of de list levelUps vol zit
                    for (int i = 0; i < levelUps.Count; i++)
                    {
                        //Als de forloop checkt dat de list niet leeg is, wordt er gekeken hoeveel de loopcounter is
                        if (levelUps[i] != null)
                        {
                            loopCounter = levelUps.Count;
                            //Als de loopcounter op 5 staat, wordt:
                            if (loopCounter == 5)
                            {
                                //Het object dat in de mazeBarricade staat vernietigd
                                Destroy(mazeBarricade);

                                //De positie van de character veranderd naar de aangegeven startPosition
                                characterPosition.position = startPosition.position;

                                //De vleugels van de engel op het wapen krijgt een licht component
                                wings.GetComponent<Light>().enabled = true;

                                //Het object dat gekoppeld staat aan de buttonObject, wordt zichtbaar in het spel
                                buttonObject.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }           
}
