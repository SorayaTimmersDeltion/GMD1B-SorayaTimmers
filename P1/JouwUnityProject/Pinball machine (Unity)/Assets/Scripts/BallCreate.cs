using UnityEngine;
using System.Collections;

public class BallCreate : MonoBehaviour {

    public Vector3 ballPos;

    public void Start()
    {
        // Start positie van de bal
        ballPos = transform.position;
    }

    // Hetaanmaken van een nieuwe bal
    public void CreateBall()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().ballsCount > 0)
        {
            Instantiate(Resources.Load("Pinball"), ballPos, Quaternion.identity);
        }
    }
}


