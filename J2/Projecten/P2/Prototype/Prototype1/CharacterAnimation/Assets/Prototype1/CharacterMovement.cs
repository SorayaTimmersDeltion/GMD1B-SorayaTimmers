using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator characterAnim;
    public bool isRunningPressed;

	// Use this for initialization
	void Start ()
    {
        characterAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Running();
	}

    public void Running()
    {
        isRunningPressed = Input.GetButton("Jump");
        characterAnim.SetBool("IsRunning", isRunningPressed);
    }

}
