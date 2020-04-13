using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playscrip : MonoBehaviour
{
   
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    public void MissionOneOpen()
    {
        SceneManager.LoadScene("SubMissionOne");
    }

    public void MissionTwoOpen()
    {
        
        SceneManager.LoadScene("SubMissionTwo");

    }

   



    public void TutorialSceneOpen()
    {
        SceneManager.LoadScene("TutorialScen");
    }

    public void OpenHomeScene()
    {
        SceneManager.LoadScene("main Menu");
    }

    public void OpenMenuScene()
    {
        SceneManager.LoadScene("MenuSceneCarParking");
    }

   


   

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("RulinRahman");
    }
        
}
