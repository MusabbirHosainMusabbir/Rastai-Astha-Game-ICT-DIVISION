using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScript : MonoBehaviour
{
    public GameObject LoadingPanel;
    public GameObject MsTwoLoadingPanel;
    // Start is called before the first frame update
    void Start()
    {
        // LoadingPanel = GameObject.Find("LoadingImage");
       LoadingPanel.SetActive(false);
        MsTwoLoadingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LodingPanelOpen()
    {
        LoadingPanel.SetActive(true);
        
    }

    public void MissionTwoLP_Open()
    {
        MsTwoLoadingPanel.SetActive(true);
    }
}
