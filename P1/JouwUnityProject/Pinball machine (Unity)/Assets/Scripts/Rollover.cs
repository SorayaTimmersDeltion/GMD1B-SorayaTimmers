using UnityEngine;
using System.Collections;

public class Rollover : MonoBehaviour {

    public bool collision;

    void OnCollisionEnter(Collision c)
    {
        collision = true;

        if (collision == true)
        {
            // Creëeren van een nieuwe bal bij een score van 100 + score wordt opgeteld bij een collision
            if (!(GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount >= 95))
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount += 5;
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().scoreCount += 5;
                GameObject.Find("BonusBalSpawn").GetComponent<BonusBal>().SpawnBonusBall();
            }
        }
    }
}
