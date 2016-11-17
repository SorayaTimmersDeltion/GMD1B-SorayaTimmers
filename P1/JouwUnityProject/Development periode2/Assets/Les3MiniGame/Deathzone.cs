using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

    public bool death;

    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);

        death = true;      
    }
}
