using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
