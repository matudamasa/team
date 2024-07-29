using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;
    public float fireDelay = 180;
    public float fireDestroy = 3.5f;

    public float moveSpeed = 3.0f; // �e�̈ړ����x
    public Transform player;
    void Update()
    {

        count += 1;
        if (player != null)
        {
            // �i�|�C���g�j
            // �U�O�t���[�����ƂɖC�e�𔭎˂���
            if (count % fireDelay == 0)
            {

                GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();

                // �T�b��ɖC�e��j�󂷂�
                Destroy(shell, fireDestroy);
            }
            // �v���C���[�̈ʒu������
            transform.LookAt(player);

            // �v���C���[�Ɍ������Ĉړ�
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}