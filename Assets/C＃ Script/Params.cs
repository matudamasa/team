using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Params : MonoBehaviour
{
    public int id = 0;    // ユニークID
    public int lv = 1;    // レベル
    public int hp = 30;    // HP
    public int hpmax = 50; // 最大HP
    public int str = 5;   // 力
    public int exp = 0;   // 獲得した経験値
    public int xp = 0;    // 倒したときに得られる経験値
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
