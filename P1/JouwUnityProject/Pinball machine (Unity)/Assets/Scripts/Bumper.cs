using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bumper : MonoBehaviour
{

    public float power;
    public bool collision;

    void OnCollisionEnter(Collision c)
    {
        //Versnelling van de ball
        c.gameObject.GetComponent<Rigidbody>().velocity *= power;
        {
            collision = true;
        }

        //Score optellen
        if (collision == true)
        {
            // Creëeren van een nieuwe bal bij een score van 100 + score wordt opgeteld bij een collision
            if (!(GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount == 90))
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount += 10;
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount += 10;
                GameObject.Find("BonusBalSpawn").GetComponent<BonusBal>().SpawnBonusBall();
            }
        }                         
    }
}
