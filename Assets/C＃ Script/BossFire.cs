using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;
    public float fireDelay = 180;
    public float fireDestroy = 2.5f;

    public float moveSpeed = 3.0f; // ’e‚ÌˆÚ“®‘¬“x
    public Transform player;

    void Update()
    {
        count += 1;

        // iƒ|ƒCƒ“ƒgj
        // ‚U‚OƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 240 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // ’e‘¬‚Í©—R‚Éİ’è
            //shellRb.AddForce(transform.forward * 500);

            // ‚T•bŒã‚É–C’e‚ğ”j‰ó‚·‚é
            Destroy(shell, 3.0f);
        }
    }
}