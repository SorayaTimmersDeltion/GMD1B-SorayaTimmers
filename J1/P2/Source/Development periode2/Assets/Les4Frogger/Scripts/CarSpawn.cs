using UnityEngine;
using System.Collections;

public class CarSpawn : MonoBehaviour
{
    public Vector3 carPos;
    public GameObject CarPrefab;
    public float timer;

    public void Update()
    {
        SpawnCar();
    }

    public void SpawnCar()
    {
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            Instantiate(CarPrefab, carPos, Quaternion.identity);
            timer = 0;
        }        
    }
}
  
