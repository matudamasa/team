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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            OnDie();
        }
    }


    void OnDie()
    {
        Destroy(gameObject);

    }
}
