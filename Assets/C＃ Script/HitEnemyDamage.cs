using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitEnemyDamage : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[5];
    private int lifePoint = 5;

    public GameObject gameOver = null;
    public GameObject gameOverButton = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(lifePoint);
        if (lifePoint == 0)
        {
            gameOver.SetActive(true);
            gameOverButton.SetActive(true);
        }
    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy")&&lifePoint > 0)
        {
           lifeArray[lifePoint - 1].SetActive(false);
           lifePoint--;
    
            OnDamage();
        }

    }

    private void OnDamage()
    {
        if (lifePoint == 0)
        {
            gameOver.SetActive(true);
            gameOverButton.SetActive(true);
        }
    }
    void OnDie()
    {
        // Scene‚ğÄ“Ç‚İ‚İ
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
