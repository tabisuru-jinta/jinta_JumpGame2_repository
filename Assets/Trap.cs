using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject panel;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("trap");
        Invoke("erase", 0.5f);
    }
    private void erase()
    {
        this.gameObject.SetActive(false);
    }
}
