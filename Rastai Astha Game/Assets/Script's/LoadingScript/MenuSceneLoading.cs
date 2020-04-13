using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneLoading : MonoBehaviour
{
    public GameObject MenuLoadingPanel;
   
    // Start is called before the first frame update
    void Start()
    {
        MenuLoadingPanel = GameObject.Find("MenuLoadingImage");
        MenuLoadingPanel.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuLoadingImageOpen()
    {
        MenuLoadingPanel.SetActive(true);
    }

   
}
