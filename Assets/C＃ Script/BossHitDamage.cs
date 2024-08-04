using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHitDamage : MonoBehaviour
{
    public float Hp = 5;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            Hp -= 1;
        }
        if (Hp == 0)
        {
            OnDie();
        }
    }


    void OnDie()
    {
        Destroy(gameObject);
    }
}
