using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMissionLevelPanelScript : MonoBehaviour
{

    public GameObject CarMissionPanel;


    public GameObject CarParkingMissionButton;
    public GameObject TutorialMission;
    public GameObject QuitButton;
    public GameObject SettingButton;
    // Start is called before the first frame update
    void Start()
    {
        CarMissionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuButtonFalse()
    {
        CarParkingMissionButton.SetActive(false);
        TutorialMission.SetActive(false);
        QuitButton.SetActive(false);
        SettingButton.SetActive(false);

        CarMissionPanel.SetActive(true);
    }
}
