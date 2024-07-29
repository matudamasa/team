using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject shellPrefab;
    private int count;
    public float fireDelay = 180;
    public float fireDestroy = 3.5f;

    public float moveSpeed = 3.0f; // 弾の移動速度
    public Transform player;
    void Update()
    {

        count += 1;
        if (player != null)
        {
            // （ポイント）
            // ６０フレームごとに砲弾を発射する
            if (count % fireDelay == 0)
            {

                GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();

                // ５秒後に砲弾を破壊する
                Destroy(shell, fireDestroy);
            }
            // プレイヤーの位置を向く
            transform.LookAt(player);

            // プレイヤーに向かって移動
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}