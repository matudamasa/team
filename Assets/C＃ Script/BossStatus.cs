using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStatus : MonoBehaviour
{

    public CharacterHp boss;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = boss.LifeMax();
        slider.value = boss.LifeMax();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = boss.Life();
    }
}
