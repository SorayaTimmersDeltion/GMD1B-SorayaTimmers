using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeMovement : MonoBehaviour {

    public bool gotHit;
    public Vector3 barricadeMovement; 

    void Start()
    {
        //De boolean staat vanaf het begin van het spel uit
        gotHit = false;
    }

	void Update ()
    {
        /*Als de boolean gotHit aan wordt gezet, 
          verplaatst het object waarin het script staat door het gebruik van de barricadeMovement*/
		if (gotHit == true)
        {
            gameObject.transform.Translate(barricadeMovement * Time.deltaTime);
        }
	}
}
