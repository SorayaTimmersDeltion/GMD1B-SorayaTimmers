using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingNumbers : MonoBehaviour
{
    public List<int> checkNumbers = new List<int>();
    public int min;

    // Use this for initialization
    void Start ()
    {
        checkNumbers = SortList(checkNumbers);
    }

    public List<int> SortList(List<int> allNumbers)
    {
        List<int> lowestNumber = new List<int>();

        for (int i = 0; i < allNumbers.Capacity; i++)
        {
            if(allNumbers[i] > min)
            {
                lowestNumber.Add(allNumbers[i]);
                Debug.Log(lowestNumber);
            }
        }
        return lowestNumber;
    }
}
