using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        GameObject.Find("ScoreLives").GetComponent<GameManager>().lives -= 1;
    }
}
