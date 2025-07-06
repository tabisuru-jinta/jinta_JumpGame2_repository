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
    float speed_y = 9.0f;
    Vector2 force_x = new Vector2(3.0f, 0);
    Vector2 start_point = new Vector2(0, 3);
    int reset_height = -3;
    float max_speed_x = 4.0f;

    float StartTime,CurrentTime ;
    bool IsGround = false;

    void Start()
    {
        transform.position = start_point;
        maincamera = GameObject.Find("Main Camera");
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("start");
        
    }

    // Update is called once per frame
    void Update()
    {
        
            maincamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);

        if(transform.position.y < reset_height)
        {
            transform.position = start_point;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D");
            if(rb.velocity.x < max_speed_x)
            {

                rb.AddForce(force_x);
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");
            if (rb.velocity.x > -max_speed_x)
            {
                rb.AddForce(-force_x);
            }
        }
        if (Input.GetKey(KeyCode.Space) && IsGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed_y);
            IsGround = false;

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        foreach(ContactPoint2D contactPoint2D in collision.contacts)
        {
            Vector2 normal = contactPoint2D.normal;
            if(normal == Vector2.up)
            {
                IsGround = true;
            }
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        IsGround = false;
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
