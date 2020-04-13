using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Uipanel;
    public GameObject UitextPanel;


   
    // Start is called before the first frame update
    void Start()
    {
        Uipanel.SetActive(false);

        UitextPanel = GameObject.Find("TimeOverPanel");


    }

    // Update is called once per frame
    void Update()
    {  
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DERACTIONBOX")
        { 
            Uipanel.SetActive(true);
            UitextPanel.SetActive(false);

        }
       
    }


   
    
}
