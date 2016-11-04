using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{

    public int score;
    public void Plus()
    {
        score += score + 1; 
    }

}