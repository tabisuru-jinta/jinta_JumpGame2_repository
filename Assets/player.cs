using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject maincamera;
    Rigidbody2D rb;
    float speed = 4.0f;
    float StartTime,CurrentTime ;

    void Start()
    {
        maincamera = GameObject.Find("Main Camera");
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("start");
        
    }

    // Update is called once per frame
    void Update()
    {
        
            maincamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);


        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D");
            rb.velocity = new Vector2(speed,rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (obj.tag == "Goal")
        {
            Debug.Log("ごーーる！！");
            SceneManager.LoadScene("ClearScene");
        }
        //Debug.Log("衝突");
    }
    

}
