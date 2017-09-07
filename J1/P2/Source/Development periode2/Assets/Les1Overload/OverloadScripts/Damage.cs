using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
    public float life;
    public float reduction;
    public float rawDamage;

    void Start()
    {
        DamageDone(rawDamage);
    }
    
    public void DamageDone(float f)
    {
        life -= TotalDamage(f);
    }

    public float TotalDamage(float f)
    {
        f *= reduction;

        return (f);
    }
}
