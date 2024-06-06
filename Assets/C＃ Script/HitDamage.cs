using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDamage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag("bullet"))
        {
            OnDie();
        }
    }

    void OnDie()
    {
        Destroy(gameObject);
    }
}
