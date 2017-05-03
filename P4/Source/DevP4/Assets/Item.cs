using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //het 3d object(item)
    public GameObject swordObject;
    //de sprite(item)
    public Sprite swordSprite;

    //het gewicht van het wapen
    public int weightStat;
    //de max snelheid die de speler met de item heeft
    public int speedStat;
    //de kracht van de item
    public int strenghtStat;
    //de verdedig van de item
    public int defenseStat;
    //hoeveel de item heelt
    public int healthStat;
    //de afstand die het item kan afleggen
    public int rangeStat;
    //de hoeveelheid magie dat het item bevat
    public int magicStat;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
