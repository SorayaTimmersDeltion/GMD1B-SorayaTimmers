using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text timeText;
    public Text lifesText;

    public float timeCount;
    public float lifesCount;

    public float pointPerSecond;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeCount += Time.deltaTime;

        lifesText.text = "Lifes: " + lifesCount;
        timeText.text = "Time: " + timeCount;

    }
}
