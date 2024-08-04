using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;
    public float fireDelay = 600;
    public float fireDestroy =1.0f;

    public float moveSpeed = 0.5f; // �e�̈ړ����x
    public Transform player;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % fireDelay == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            //shellRb.AddForce(transform.forward * 500);

            // �T�b��ɖC�e��j�󂷂�
            Destroy(shell, 1.0f);
        }
    }
}