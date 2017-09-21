using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    public List<int> checkNumbers = new List<int>();

    // Use this for initialization
    void Start()
    {
        checkNumbers = GetOddNumbers(checkNumbers);
    }

    public List<int> GetOddNumbers(List<int> allNumbers)
    {
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < allNumbers.Count; i++)
        {
            if (allNumbers[i] % 2 != 0)
            {
                oddNumbers.Add(allNumbers[i]);
                Debug.Log(allNumbers[i]);
            }
        }
        return oddNumbers;
    }
}

