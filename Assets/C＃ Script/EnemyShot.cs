using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 360 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            shellRb.AddForce(transform.forward * 500);

 
            // 1�b��ɖC�e��j�󂷂�
            Destroy(shell, 1.0f);
        }
    }
}