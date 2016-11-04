using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerCollision;

    public int lives;

	// Use this for initialization
	void Start () {
        lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
        
        // Als de bal een bumper raakt
        scoreCount += pointsPerCollision + Time.deltaTime;

        // Nieuw highscore
        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
        }

        // Het veranderen van de text (score en highScore)
        scoreText.text = "Score: " + scoreCount;
        highScoreText.text = "High score: " + highScoreCount;

	}
}