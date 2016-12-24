using UnityEngine;
using System.Collections;

public class Les1Test1 : MonoBehaviour
{
    public int test;

    void OnCollisionEnter()
    {
        GameObject.Find("Sphere").GetComponent<Les1Test3>().TestFunctie(test);
    }
}
