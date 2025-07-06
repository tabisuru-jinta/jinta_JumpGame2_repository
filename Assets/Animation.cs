using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
        Debug.Log("animation");
    }
    //public void BottonClickFun()
    //{
    //    animator.SetTrigger("testTriger");
    //}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("testTriger");
    }
}
