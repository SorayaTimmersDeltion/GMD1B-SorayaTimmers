using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPosition;
    public Transform character;

    void OnCollisionEnter(Collision c)
    {
        /*als het object waar dit script op staat botst met een object met de tag Character,
          zal het object met de tag respawnen op de aangegeven respawnPosition*/
        if (c.gameObject.tag == "Character")
        {
            character.position = respawnPosition.position;
        }
    }
}
