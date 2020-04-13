using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartTutorialSceneButton : MonoBehaviour
{

    public GameObject FastUiPanel;
    public GameObject LastUiPanel;
    // Start is called before the first frame update
    void Start()
    {
        FastUiPanel = GameObject.Find("TutorialFastPanel");
        LastUiPanel = GameObject.Find("TutorialLastPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartButton()
    {
        FastUiPanel.SetActive(true);
        LastUiPanel.SetActive(false);
    }
}
