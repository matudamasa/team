using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{

    private float Speed = 5f;

    private const float RotateSpeed = 720f;

    private Rigidbody rb;

    //[SerializeField]
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // パスでカメラを参照して情報を取得している。
        camera = GameObject.Find("/Camera");

    }

    // Update is called once per frame
    void Update()
    {
        // キーボード入力を進行方向のベクトルに変換して返す
        Vector3 direction = InputToDirection();

        UpdatePosition(direction);
    }

    private Vector3 InputToDirection()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(x, 0f, z);

        return direction.normalized;
    }

    private void UpdatePosition(Vector3 direction)
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(camera.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * direction.z + camera.transform.right * direction.x;
        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す
        rb.velocity = moveForward * Speed + new Vector3(0, rb.velocity.y, 0);
        
        // キー入a力により移動方向が決まっている場合には、キャラクターの向きを進行方向に合わせる
        if (moveForward != Vector3.zero)
        {
            Quaternion from = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(from, Quaternion.LookRotation(moveForward),
                RotateSpeed * Time.deltaTime);
        }
    }
}
