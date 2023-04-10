using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float speed;
    

    
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rgb.velocity = new Vector2(x * speed, y * speed);
      

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed++;
        if (SceneManager.GetActiveScene().name == "playervsai"){
            
        if (collision.gameObject.CompareTag("PlayerWall"))
        {
            Debug.Log("playerwalltest");
            OyunYonetimi.instance.DusmanPuanEkle(1);
            //dusmanPuan++;
          //  UpdatePuanText();
            SceneManager.LoadScene("playervsai");
        }
        if (collision.gameObject.CompareTag("EnemyWall"))
        {
            OyunYonetimi.instance.PlayerPuanEkle(1);
            Debug.Log("enemywalltest");
           // oyuncuPuan++;
           // UpdatePuanText();
           SceneManager.LoadScene("playervsai");
        } 
        }

        if (SceneManager.GetActiveScene().name == "aivsai")
        {
            
            if (collision.gameObject.CompareTag("PlayerWall"))
            {
                Debug.Log("playerwalltest");
                OyunYonetimi.instance.DusmanAIPuanEkle(1);
                //dusmanPuan++;
                //  UpdatePuanText();
                SceneManager.LoadScene("aivsai");
            }
            if (collision.gameObject.CompareTag("EnemyWall"))
            {
                OyunYonetimi.instance.PlayerAIPuanEkle(1);
                Debug.Log("enemywalltest");
                // oyuncuPuan++;
                // UpdatePuanText();
                SceneManager.LoadScene("aivsai");
            }
        }
    }

}

