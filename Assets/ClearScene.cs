using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    public void OnTitleButtonClick()
    {
        Debug.Log("タイトルボタンが押された！");
        SceneManager.LoadScene("StartScene");
    }
}
