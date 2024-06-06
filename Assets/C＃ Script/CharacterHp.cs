using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHp : MonoBehaviour
{
    public int maxHp = 100;

    int hp;

    public int Hp
    {
        get { return hp; }
        set
        {
            hp = Mathf.Clamp(value, 0, maxHp);

            //if (hp <= 0)
            //{
            //    Death();
            //}
        }
    }

    public int Life()
    {
        return hp;
    }

    void Start()
    {
        Hp = maxHp;
    }

    void Update()
    {

    }
}
