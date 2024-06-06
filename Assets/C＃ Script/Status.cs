using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class Status : MonoBehaviour
{

    public CharacterHp player;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        int score = player.Life(); ;
        scoreText.text = "EnemyLifeÅF" + score;
    }
}
