using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update

    float ShowTxtTime = 1;//"�Q�[���X�^�[�g�I"��\������b��
    //GameObject go;
    void Start()
    {
        Invoke("Change_StartCall", ShowTxtTime);
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Change_StartCall()
    {
        //go.SetActive(false);
        Debug.Log("change!!!");
        this.gameObject.SetActive(false);
    }
}
