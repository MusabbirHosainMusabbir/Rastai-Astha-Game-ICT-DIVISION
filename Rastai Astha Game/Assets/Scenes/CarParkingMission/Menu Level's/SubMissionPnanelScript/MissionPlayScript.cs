using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionPlayScript : MonoBehaviour
{
    public GameObject LoodingImage;
    // Start is called before the first frame update
    void Start()
    {
        LoodingImage.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MissionOneOpen()
    {
        SceneManager.LoadScene("SubMissionOne");
        LoodingImage.SetActive(true);
    }
}
