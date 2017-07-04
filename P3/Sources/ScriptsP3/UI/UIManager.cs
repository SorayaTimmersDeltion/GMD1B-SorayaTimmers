using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject textButton;
    public Text dialogueText;

	void Start ()
    {
        textButton.SetActive(false); 
	}
}
