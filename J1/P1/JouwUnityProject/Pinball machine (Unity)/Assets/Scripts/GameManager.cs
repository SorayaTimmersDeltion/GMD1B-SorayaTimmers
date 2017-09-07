using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // Score en levens texts
    public Text scoreText;
    public Text ballsText;
    
    // Score en levens floats
    public float scoreCount;
    public float ballsCount;

	// Use this for initialization
	void Start ()
    {  

	}
	
	// Update is called once per frame
	void Update ()
    {      

        // Het veranderen van de text (score en highScore)
        scoreText.text = "Score: " + scoreCount;
        ballsText.text = "Balls x " + ballsCount;                
 	}
}