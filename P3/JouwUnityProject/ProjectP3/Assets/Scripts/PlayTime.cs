using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    public int playTimeInt;
    public float playTime;
    public Text playTimeText;

	void Update ()
    {
        playTimeInt = Mathf.RoundToInt(playTime);
        playTime -= Time.deltaTime;
        playTimeText.text = "Time Left: " + playTimeInt;
	}
}
