using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    //Een list van itemImages, gebasseerd op de hoeveelheid itemSlots   //public Image[] itemImages = new Image[numItemSlots];
    public List<Image> itemImages = new List<Image>(numItemSlots);
    public List<Item>

 
    //const geeft aan dat deze gedurende het spel niet te veranderen is door code.
    public const int numItemSlots = 2;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}



//https://unity3d.com/learn/tutorials/projects/adventure-game-tutorial/inventory 

