using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
    }
}
