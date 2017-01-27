using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

	// Use this for initialization
	void Start ()
    {
        print(Test.o);

        DontDestroyOnLoad(gameObject);

        if (gm == null)
        {
            gm = this;
        }

        else if(gm != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
