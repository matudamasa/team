using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;
    public float fireDelay = 180;
    public float fireDestroy = 2.5f;

    public float moveSpeed = 3.0f; // �e�̈ړ����x
    public Transform player;

    void Update()
    {
        count += 1;

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 240 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            //shellRb.AddForce(transform.forward * 500);

            // �T�b��ɖC�e��j�󂷂�
            Destroy(shell, 3.0f);
        }
    }
}