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
    //    Debug.Log("�V�[����ς���");
    //    SceneManager.LoadScene("GameScene");
        
    //}
    public void OnStartButtonClick()
    {
        Debug.Log("�X�^�[�g�{�^���������ꂽ�I");
        SceneManager.LoadScene("GameScene");
    }
}
