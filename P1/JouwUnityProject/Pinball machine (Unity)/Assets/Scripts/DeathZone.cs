using UnityEngine;
using System.Collections;
using System;

public class DeathZone : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballClone;
    public Transform spawnPosition;

    public bool death;

    void Start()
    {
        ballPrefab = GameObject.Find("Pinball");
    }

    void OnCollisionEnter(Collision c)
    {       
        // Pinball wordt vernietigd
        Destroy(c.gameObject);
        {
            death = true;
        }

        // Leven eraf
        if (death == true)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().ballsCount -= 1;
        }     

        //Een nieuwe bal laten spawnen
        GameObject.Find("BallCreator").GetComponent<BallCreate>().CreateBall();        
    }

}
