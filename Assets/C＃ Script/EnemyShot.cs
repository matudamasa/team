using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;

    float moveEnemy = TrackingPlayer.moveNow;   // “®‚¢‚Ä‚¢‚é‚Æ‚«(1) || ~‚Ü‚Á‚Ä‚¢‚é‚Æ‚«(0)

    void Update()
    {
        count += 1;

        if (TrackingPlayer.moveNow == 1)
        {

            // iƒ|ƒCƒ“ƒgj
            // ‚U‚OƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
            if (count % 360 == 0)
            {
                GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();

                // ’e‘¬‚Í©—R‚Éİ’è
                shellRb.AddForce(transform.forward * 500);


                // 1•bŒã‚É–C’e‚ğ”j‰ó‚·‚é
                Destroy(shell, 1.0f);
            }
        }
        else
        {
            TrackingPlayer.moveNow = 0;
        }
    }
}