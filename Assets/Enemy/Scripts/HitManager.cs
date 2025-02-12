using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HitManager : MonoBehaviour
{
    [SerializeField]
    float hitPoints = 25;
    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;
        Debug.Log("HAHA: " + hitPoints.ToString());
        if (hitPoints <= 0)
        {
            Invoke("SelfTerminate", 0f);
            Debug.Log("Enemy is dead");
        }
    }
    void SelfTerminate()
    {
        Destroy(gameObject);
    }
}
