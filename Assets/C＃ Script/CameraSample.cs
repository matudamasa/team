using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSample : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追従させたいターゲット")]
    private GameObject target;

    private Vector3 offset;
    internal static Camera main;

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時点のカメラとターゲットの距離（オフセット）を取得
        offset = gameObject.transform.position - target.transform.position;
    }

    /// <summary>
    /// プレイヤーが移動した後にカメラが移動するようにするためにLateUpdateにする。
    /// </summary>
    void LateUpdate()
    {
        // カメラの位置をターゲットの位置にオフセットを足した場所にする。
        gameObject.transform.position = target.transform.position + offset;
    }

    internal Vector3 ScreenToWorldPoint(Vector3 position)
    {
        throw new NotImplementedException();
    }
}
