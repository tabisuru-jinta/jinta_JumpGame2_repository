using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    Invoke("ChangeCsene", 3f);
        
    //}

    ////// Update is called once per frame
    //void Update()
    //{

    //}
    //void ChangeCsene()
    //{
    //    Debug.Log("シーンを変える");
    //    SceneManager.LoadScene("GameScene");
        
    //}
    public void OnStartButtonClick()
    {
        Debug.Log("スタートボタンが押された！");
        SceneManager.LoadScene("GameScene");
    }
}
