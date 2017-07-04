using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    RaycastHit hit;
    public float raycastLength;

    //public Dialogue dialogueScript;
    public UIManager uiScript;
    public Dialogue dialogueScript;

    public int positiveAnswers;
    public int negativeAnswers;

    public int indexInt;

    public bool positiveBool;
    public bool negativeBool;

    public GameObject character;

	void Update ()
    {
        positiveAnswers = 0;
        negativeAnswers = 0;

        conversationRayCast();

        if (positiveAnswers >= negativeAnswers)
        {
            positiveBool = true;
            negativeBool = false;
        }
        else if (negativeAnswers >= positiveAnswers)
        {
            negativeBool = true;
            positiveBool = false;
        }
	}

    public void conversationRayCast()
    {
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.green, 0.2f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength))
        {
            if(hit.collider.tag == "NPC")
            {
                dialogueScript = hit.collider.GetComponent<Dialogue>();

                if (Input.GetButtonDown("Jump"))
                {
                    uiScript.textButton.SetActive(true);
                    character.GetComponent<CharacterMovement>().enabled = false;
                }
                if (Input.GetKeyDown("y"))
                {
                    print("YES");
                    uiScript.dialogueText.text = dialogueScript.conversationIndex[indexInt];
                    positiveAnswers += 1;
                    dialogueScript.conversationIndex[indexInt] += 1;
                }                

                if (Input.GetKeyDown("n"))
                {
                    print("NO");
                    uiScript.dialogueText.text = dialogueScript.conversationIndex[indexInt];
                    negativeAnswers += 1;
                    dialogueScript.conversationIndex[indexInt] += 1;
                }
            }
        }
    }
}
