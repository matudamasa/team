using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrackingPlayer : MonoBehaviour
{

    public GameObject goal; //����Ƀv���C���[���i�[
    public NavMeshAgent agent; //�@�G�������œ������߂ɕK�v
    public float distance; //�A�v���C���[�ƓG�̋������i�[����ϐ�(distane=����)

    public static float moveNow = 0;   // �����Ă���Ƃ�1 || �~�܂��Ă���Ƃ�0

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();�@//�@
        goal = GameObject.Find("Cara");
        Debug.Log(moveNow); // �����Ă��邩
    }

    // Update is called once per frame
    void Update()
    {

        //�A��ҊԂ̋������v�Z����float�@���l�����ɂȂ�ΒǐՂ���
        distance = Vector3.Distance(transform.position, goal.transform.position);
        Debug.Log(distance);

        if (distance < 10)
        {
            moveNow = 1;    
            agent.destination = goal.transform.position; //�@
        }
        else {
            moveNow = 0;
        }

   
    }
}
