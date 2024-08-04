using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHitDamage : MonoBehaviour
{
    public float Hp = 5;

    public GameObject gameClear;
    public GameObject buttonClear;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            Hp -= 1;
        }
        if (Hp == 0)
        {
            gameClear.SetActive(true);
            buttonClear.SetActive(true);
            OnDie();
        }
    }


    void OnDie()
    {
        Destroy(gameObject);
    }
}
