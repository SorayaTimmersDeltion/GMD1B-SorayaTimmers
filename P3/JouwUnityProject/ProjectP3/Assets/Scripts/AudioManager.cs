using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip runestoneClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "RuneAudio")
        {
            audioSource.clip = runestoneClip;
            audioSource.Play();
        }
    }
}
